package main

import "fmt"

func main() {
	for i := 0; i <= 10; i++ {
		if i%2 == 0 {
			fmt.Println(i, "is even")
			continue
		}
		fmt.Println(i, "is odd")
	}
}