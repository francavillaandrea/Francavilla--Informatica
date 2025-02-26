#define PIN_TX 2

#define bigEndian 1
#define Tb 1000
#define Nb 8

const char parity = 'N';
const int data = 0b10101010; //0xAA 

typedef enum{
	Idle,
	Start,
	Data,
	Parity,
	Stop1,
	Stop2
}State;

State current_state = Idle;
int currentBit = 0;


void setup() {
  pinMode(PIN_TX, OUTPUT); //eseguita solo all'avvio del sistema diciamo come deve lavorare il sistema
  Serial.begin(9600);
  Serial.print("\ninit\n");
  digitalWrite(PIN_TX, HIGH);
}


void loop() {
	txMachine();
}


void txMachine(){
	State future_state = current_state;
	switch(current_state){
		case Idle:
			future_state = Start;
			Serial.print("\n");
			break;
		case Start:
			transmitBit(0);
			future_state = Data;
			break;
		case Data:
			handleDataTx();
			}
		
	current_state = future_state;
}

void handleDataTx() {
	int bit = extractBit(data, currentBit);
	transmitBit(bit);
	currentBit++;
}

int extractBit(int data, int i)
{
    int mask = 0b1 << i;
    int res = data & mask;
    if(res > 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

void transmitBit(int bit)
{
    if(bit == 1)
    {
        digitalWrite(PIN_TX, HIGH);

    }
    else
    {
        digitalWrite(PIN_TX, LOW);
    }
    Serial.print(bit);
}



