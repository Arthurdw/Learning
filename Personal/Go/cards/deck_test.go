package main

import (
	"os"
	"testing"
)

func testDeck(t *testing.T, d deck) {
	if len(d) != 48 {
		t.Errorf("Expected 48 cards, got %d", len(d))
	}

	if d[0] != "Ace of Spades" {
		t.Errorf("Expected first card to be 'Ace of Spades', got '%v'", d[0])
	}

	if d[len(d)-1] != "King of Clubs" {
		t.Errorf("Expected second card to be 'King of Clubs', got '%v'", d[len(d)-1])
	}
}

func cleanup() {
	os.Remove("_decktesting")
}

func TestNewDeck(t *testing.T) {
	testDeck(t, newDeck())
}

func TestSaveToDeckAndNewDeckFromFile(t *testing.T) {
	cleanup()

	deck := newDeck()
	deck.saveToFile("_decktesting")

	loadedDeck := newDeckFromFile("_decktesting")
	testDeck(t, loadedDeck)

	cleanup()
}
