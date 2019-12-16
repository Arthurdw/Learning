// Code created by ©Arthurdw to prepare for the electronics exam from Go-AO!
//
// A little passcode construction.
// The led light will be green if the passcode was right.
// If the passcode was wrong the light will glow red nad the arduino will be frozen like this for 30 seconds.

// Is `x`allowed to pass?
bool allowed = false;

// Passcode counter.
// This will cause the `red light error` when a wrong password has been given!
int counter = 0;

// Passcode checks:
bool passed1 = false;
bool passed2 = false;
bool passed3 = false;
bool passed4 = false;

// Is blue currently the light color?
bool currentBlue = false;

// Arduino setup function:
void setup() {
    // Basic button declarations:
    pinMode(2, INPUT_PULLUP);
    pinMode(3, INPUT_PULLUP);
    pinMode(4, INPUT_PULLUP);
    pinMode(5, INPUT_PULLUP);

    // Led declaration:
    pinMode(8, OUTPUT);
    pinMode(9, OUTPUT);
    pinMode(10, OUTPUT);
}

// Artuino loop function:
void loop() {
    // Passcode:
    if (digitalRead(4) == LOW) {
        passed1 = true;
        ++counter;
        delay(100); // Wait 0.1s because else it will keep counting way to fast.
    } else if (passed1) {
        if (digitalRead(2) == LOW) {
            passed2 = true;
            ++counter;
            delay(100); // Wait 0.1s because else it will keep counting way to fast.
        }
    } else if (passed2) {
        if (digitalRead(5) == LOW) {
            passed3 = true;
            ++counter;
            delay(100); // Wait 0.1s because else it will keep counting way to fast.
        }
    } else if (passed3) {
        if (digitalRead(3) == LOW) {
            passed4 = true;
            ++counter;
            delay(100); // Wait 0.1s because else it will keep counting way to fast.
        }
    }

    // Do lights ect when the fourth button has been activated:
    if (passed4) {
        digitalWrite(9, LOW);
        digitalWrite(8, HIGH);
        currentBlue = false;
        counter = 0;
        delay(10000); // Lets just display the green light for 10 seconds.
    } else {
        if (!currentBlue) {
            digitalWrite(8, LOW);
            digitalWrite(9, HIGH);
            digitalWrite(10, LOW);
            currentBlue = true;
        }
    }

    // Too many tries:
    if (counter > 4) {
        digitalWrite(9, LOW);
        digitalWrite(10, HIGH);
        currentBlue = false;
        counter = 0;
        delay(30000); // Display the `red error light` for 30 seconds.
        passed1 = passed2 = passed3 = passed4 = false;
    }

    delay(10); // Delay a bit to improve performance
}