package main

import (
	"bufio"
	"fmt"
	"net/http"
	"os"
	"strings"
)

type SiteState struct {
	state          string
	url            string
	httpStatusCode int
}

func isOnline(c chan SiteState, pageUrl string) {
	res, err := http.Get(pageUrl)

	if err != nil {
		c <- SiteState{state: "offline", url: pageUrl, httpStatusCode: 0}
	} else {
		c <- SiteState{state: "online", url: pageUrl, httpStatusCode: res.StatusCode}
	}
}

func main() {
	var filename string

	if len(os.Args) != 2 {
		reader := bufio.NewReader(os.Stdin)
		fmt.Println("Please enter a file which contains the domain names to check:")
		text, _ := reader.ReadString('\n')

		filename = strings.TrimSuffix(text, "\n")
	} else {
		filename = os.Args[1]
	}

	if _, err := os.Stat(filename); os.IsNotExist(err) {
		fmt.Println("File does not exist")
		return
	}

	data, err := os.ReadFile(filename)

	if err != nil {
		fmt.Println(err)
		return
	}

	comm := make(chan SiteState)
	urls := strings.Split(string(data), "\n")
	urls_left := len(urls)

	for _, uri := range urls {
		if uri == "" {
			urls_left--
			continue
		}

		go isOnline(comm, uri)
	}

	for message := range comm {
		fmt.Printf("%s [%d]: %s\n", message.state, message.httpStatusCode, message.url)

		urls_left--
		if urls_left == 0 {
			break
		}
	}
}
