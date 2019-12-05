package main

import (
	"bufio"
	"database/sql"
	"encoding/csv"
	"fmt"
	"io"
	"os"
	"runtime"

	"strings"

	_ "github.com/denisenkom/go-mssqldb"
)

func main() {
	var menuItems []MenuItem
	var filePath string
	var password string
	var lineEndings string
	if runtime.GOOS == "windows" {
		lineEndings = "\r\n"
	} else {
		lineEndings = "\n"
	}
	if len(os.Args) < 3 {
		reader := bufio.NewReader(os.Stdin)
		fmt.Print("Enter path to the member CSV file: ")
		filePath, _ = reader.ReadString('\n')
		filePath = strings.TrimRight(filePath, lineEndings)
		fmt.Print("Enter the SQL server password: ")
		password, _ = reader.ReadString('\n')
		password = strings.TrimRight(password, lineEndings)
	} else {
		filePath = os.Args[1]
		password = os.Args[2]
	}

	insertQuery := `UPDATE Menu 
						SET Day = '%[1]v',
						Dinner = '%[2]v',
						Lunch = '%[3]v'
					WHERE Date = '%[4]v'
					if @@rowcount = 0
					begin
						insert into Menu values ('%[4]v', '%[1]v', '%[2]v', '%[3]v')
					end
					`
	var sb strings.Builder
	//_, _ = sb.WriteString(insertQuery)

	file, err := os.Open(filePath)

	PrintError(err)

	r := csv.NewReader(file)

	// Read the CSV file into memory
	for {
		line, err := r.Read()
		if err == io.EOF {
			break
		}
		var temp MenuItem
		date := line[0]
		day := line[1]
		dinner := line[2]
		lunch := line[3]
		temp = MenuItem{date, day, dinner, lunch}
		menuItems = append(menuItems, temp)
		PrintError(err)
	}

	fmt.Printf("%d Items in file\n", len(menuItems))
	fmt.Println("Connecting to database . . .")
	db, err := sql.Open("mssql", fmt.Sprintf("sqlserver://sa:%s@192.168.0.15?database=FH", password))
	PrintError(err)

	// Add values from CSV into the insert query
	for _, item := range menuItems {
		_, err := sb.WriteString(fmt.Sprintf(insertQuery, item.Day, item.Dinner, item.Lunch, item.Date))

		PrintError(err)
	}
	fmt.Println(sb.String())
	// Insert data into the database
	_, err = db.Exec(sb.String())
	PrintError(err)

	db.Close()
}

// Menu item struct to hold menu stuff
type MenuItem struct {
	Date   string
	Day    string
	Lunch  string
	Dinner string
}

// PrintError prints an error you give it
func PrintError(err error) {
	if err != nil {
		panic(err)
	}
}