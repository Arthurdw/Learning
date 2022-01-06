package main

import (
	"fmt"
	"io"
	"net/http"
	"os"
)

type logWriter struct{}

func main() {
	resp, err := http.Get("https://www.google.com")

	if err != nil {
		fmt.Println("Error:", err.Error())
		os.Exit(1)
	}

	//bs := make([]byte, 99999)
	//resp.Body.Read(bs)
	//fmt.Println(string(bs))

	//body, err := io.ReadAll(resp.Body)
	//
	//if err != nil {
	//	fmt.Println("Error:", err.Error())
	//	os.Exit(1)
	//}
	//
	//fmt.Println(string(body))

	//io.Copy(os.Stdout, resp.Body)

	io.Copy(logWriter{}, resp.Body)
}

func (logWriter) Write(bs []byte) (int, error) {
	fmt.Println(string(bs))
	fmt.Println("Just wrote this many bytes:", len(bs))
	return len(bs), nil
}
