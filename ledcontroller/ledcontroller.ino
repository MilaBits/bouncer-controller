//set pins
const int ledAR = 2;
const int ledAG = 3;

const int ledBR = 4;
const int ledBG = 5;

const int ledCR = 6;
const int ledCG = 7;

const int ledDR = 8;
const int ledDG = 9;

const byte numChars = 5;
char receivedChars[numChars]; // an array to store the received data

boolean newData = false;

void setup() {

  pinMode(ledAR, OUTPUT);
  pinMode(ledAG, OUTPUT);

  pinMode(ledBR, OUTPUT);
  pinMode(ledBG, OUTPUT);

  pinMode(ledCR, OUTPUT);
  pinMode(ledCG, OUTPUT);

  pinMode(ledDR, OUTPUT);
  pinMode(ledDG, OUTPUT);

  Serial.begin(9600);
  Serial.println("<Arduino is ready>");
}

void loop() {
  recvWithEndMarker();
  showNewData();

  ledOn(1, receivedChars[0]);
  ledOn(2, receivedChars[1]);
  ledOn(3, receivedChars[2]);
  ledOn(4, receivedChars[3]);
}

void ledOn(int led, int color) {
  if (led == 1) {
    if (color == 48) {
      digitalWrite(ledAG, LOW);
      digitalWrite(ledAR, LOW);
    }
    if (color == 49) {
      digitalWrite(ledAG, LOW);
      digitalWrite(ledAR, HIGH);
    }
    if (color == 50){    
      digitalWrite(ledAG, HIGH);
      digitalWrite(ledAR, LOW);
    }
    Serial.print(color);
  }
  if (led == 2) {
    if (color == 48) {
      digitalWrite(ledBG, LOW);
      digitalWrite(ledBR, LOW);
    }
    if (color == 49) {
      digitalWrite(ledBG, LOW);
      digitalWrite(ledBR, HIGH);
    }
    if (color == 50){    
      digitalWrite(ledBG, HIGH);
      digitalWrite(ledBR, LOW);
    }
    Serial.print(color);
  }
  if (led == 3) {
    if (color == 48) {
      digitalWrite(ledCG, LOW);
      digitalWrite(ledCR, LOW);
    }
    if (color == 49) {
      digitalWrite(ledCG, LOW);
      digitalWrite(ledCR, HIGH);
    }
    if (color == 50){    
      digitalWrite(ledCG, HIGH);
      digitalWrite(ledCR, LOW);
    }
    Serial.print(color);
  }
  if (led == 4) {
    if (color == 48) {
      digitalWrite(ledDG, LOW);
      digitalWrite(ledDR, LOW);
    }
    if (color == 49) {
      digitalWrite(ledDG, LOW);
      digitalWrite(ledDR, HIGH);
    }
    if (color == 50){    
      digitalWrite(ledDG, HIGH);
      digitalWrite(ledDR, LOW);
    }
    Serial.print(color);
  }
  Serial.println();
//  Serial.print("led ");
//  Serial.print(led);
//  Serial.print(" aan, kleur: ");
//  Serial.println(color);
}

void recvWithEndMarker() {
  static byte ndx = 0;
  char endMarker = '\n';
  char rc;

  // if (Serial.available() > 0) {
  while (Serial.available() > 0 && newData == false) {
    rc = Serial.read();

    if (rc != endMarker) {
      receivedChars[ndx] = rc;
      ndx++;
      if (ndx >= numChars) {
        ndx = numChars - 1;
      }
    }
    else {
      receivedChars[ndx] = '\0'; // terminate the string
      ndx = 0;
      newData = true;
    }
  }
}

void showNewData() {
  if (newData == true) {
    Serial.print("This just in ... ");
    Serial.println(receivedChars);
    newData = false;
  }
}
