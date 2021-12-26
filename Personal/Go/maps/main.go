package main

import "fmt"

func main() {
	//var colors map[string]string
	//colors := make(map[string]string)
	//
	//colors["red"] = "#ff0000"
	//fmt.println(colors)
	//
	//delete(colors, "red")
	//fmt.println(colors)

	colors := map[string]string{
		"red":   "#ff0000",
		"green": "#4bf745",
		"white": "#ffffff",
	}

	printMap(colors)
	//
	//fmt.Println(colors["red"])
	//
	//sample := map[string]int{
	//	"a": 1,
	//	"b": 2,
	//	"c": 3,
	//}
	//
	//fmt.Println(sample)
}

func printMap(c map[string]string) {
	for color, hex := range c {
		fmt.Println("Hex code for", color, "is", hex)
	}
}
