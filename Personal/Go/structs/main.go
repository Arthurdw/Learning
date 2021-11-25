package main

import "fmt"

type person struct {
	firstName string
	lastName  string
}

func (p *person) updateName(newFirstName string) {
	(*p).firstName = newFirstName
}

func main() {
	alex := person{
		firstName: "Alex",
		lastName:  "Anderson",
	}

	alex.updateName("Alexey")
	fmt.Printf("%+v", alex)
}
