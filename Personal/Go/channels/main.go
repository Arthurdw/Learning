package main

import (
	"fmt"
	"net/http"
	"time"
)

func main() {
	links := []string{
		"https://www.nonexistent.com",
		"https://www.google.com",
		"https://www.facebook.com",
		"https://www.amazon.com",
		"https://www.youtube.com",
		"https://www.instagram.com",
		"https://www.twitter.com",
		"https://www.linkedin.com",
		"https://www.github.com",
		"https://www.reddit.com",
		"https://www.stackoverflow.com",
		"https://www.quora.com",
		"https://www.pinterest.com",
	}

	c := make(chan string)

	for _, link := range links {
		go checkStatus(c, link)
	}

	for l := range c {
		go func(link string) {
			time.Sleep(5 * time.Second)
			go checkStatus(c, link)
		}(l)
	}
}

func checkStatus(c chan string, link string) {
	_, err := http.Get(link)
	if err != nil {
		fmt.Println("DOWN", link)
		c <- link
		return
	}

	fmt.Println("  UP", link)
	c <- link
}
