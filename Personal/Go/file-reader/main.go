package main

import (
	"fmt"
	"io"
	"os"
)

func main() {
	arguments := os.Args[1:]

	if len(arguments) != 1 {
		fmt.Println("Must pass one file which contains the text to be read")
		os.Exit(1)
	}

	file, err := os.Open(arguments[0])
	if err != nil {
		fmt.Println(err)
		os.Exit(1)
	}

	if _, err := io.Copy(os.Stdout, file); err != nil {
		fmt.Println(err)
		os.Exit(1)
	}
}
