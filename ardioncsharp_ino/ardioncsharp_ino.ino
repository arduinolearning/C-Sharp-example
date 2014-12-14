
#define LEDPin    4

char SerialInput;

void setup()
{
  pinMode(LEDPin, OUTPUT);
  // serial communication
  Serial.begin(9600);
}
void loop()
{
     //read from serial port
     SerialInput = Serial.read();
     //verify incomingOption
     switch(SerialInput)
     {
        case '1':
          // Turn ON LED
          digitalWrite(LEDPin, HIGH);
          break;
          
        case '0':
          // Turn OFF LED
          digitalWrite(LEDPin, LOW);
          break;
     }
}
