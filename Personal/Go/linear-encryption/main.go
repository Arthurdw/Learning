// A golang implementation of Linear Encryption
// Do NOT use this for sensitive data as linear encryption is extremely easy to crack.
package main

import (
	"fmt"
	"math/big"
)

const TableSize = 256

type byteDigest func(int, int, int, []byte)

func main() {
	plaintext := "Hello Eve!"
	encrypted := encrypt("super secret", "key", plaintext)
	decrypted := decrypt("super secret", "key", encrypted)
	fmt.Println(encrypted)
	fmt.Println(decrypted)
}

func getInverse(n int) int {
	num := big.NewInt(int64(n))
	bigTS := big.NewInt(int64(TableSize))

	return int((bigTS.ModInverse(num, bigTS)).Int64())
}

func sum(collection []byte) int {
	sum := 0
	for _, v := range collection {
		sum += int(v)
	}

	return sum
}

func encrypt(key1 string, key2 string, plaintext string) string {
	digest := func(i int, alpha int, beta int, res []byte) {
		res[i] = byte((alpha*int(res[i]) + beta) % TableSize)
	}

	return processDigest(key1, key2, plaintext, false, digest)
}

func decrypt(key1 string, key2 string, ciphertext string) string {
	digest := func(i int, alpha int, beta int, res []byte) {
		res[i] = byte(alpha * (int(res[i]) - beta) % TableSize)
	}

	return processDigest(key1, key2, ciphertext, true, digest)
}

func processDigest(key1 string, key2 string, text string, invertAlpha bool, digest byteDigest) string {
	alpha := sum([]byte(key1))
	beta := sum([]byte(key2))

	res := []byte(text)

	if invertAlpha {
		alpha = getInverse(alpha)
	}

	for i := 0; i < len(res); i++ {
		digest(i, alpha, beta, res)
	}

	return string(res)
}
