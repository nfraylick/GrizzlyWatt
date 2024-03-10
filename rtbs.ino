#include <mcp_can.h>
#include <SPI.h>

// Set CS to pin 10
MCP_CAN CAN(10);

const int ANALOG_IN_PIN = A0;
const int TEMP_SENSOR_PIN = A1; // Analog temperature sensor
const float MAX_BATTERY_VOLTAGE = 4.2; // Max voltage of battery when fully charged (per cell)
const int NUM_CELLS = 3; // Number of cells in series (example value)

// A fictional discharge curve. In real life, this would be experimental data.
float dischargeCurve(float voltage) {
  // This function would map voltage to SOC based on actual discharge characteristics
  // For simplicity, we'll assume a linear discharge curve, which is not accurate.
  return (voltage / (MAX_BATTERY_VOLTAGE * NUM_CELLS)) * 100.0;
}

// Function to simulate temperature effect on battery voltage
float temperatureEffect(int rawTempValue) {
  // Convert the raw temperature sensor value to an actual temperature (°C)
  // Assume a linear relationship for simplicity: 0°C at 0 raw value, 50°C at 1023
  float temperatureC = (rawTempValue / 1023.0) * 50.0;

  // Adjust voltage based on temperature. Many chemical batteries perform worse in cold weather.
  // This is a made-up formula for illustrative purposes.
  return 1.0 - (0.01 * (25.0 - temperatureC)); // 1% decrease per degree below 25°C
}

void setup() {
// Initialize serial communications at 115200 bps:
  Serial.begin(115200);

  // Initialize CAN:
  if (CAN.begin(MCP_ANY, CAN_500KBPS, MCP_8MHZ) == CAN_OK) {
    Serial.println("CAN init ok!");
  } else {
    Serial.println("CAN init failed!");
  }

  Serial.begin(9600);
  pinMode(ANALOG_IN_PIN, INPUT);
  pinMode(TEMP_SENSOR_PIN, INPUT);
}

void loop() {
  int rawVoltage = analogRead(ANALOG_IN_PIN);
  int rawTemperature = analogRead(TEMP_SENSOR_PIN);
  
  // Convert rawVoltage (0 to 1023) to actual voltage
  float voltage = (rawVoltage / 1023.0) * (MAX_BATTERY_VOLTAGE * NUM_CELLS);
  // Adjust voltage based on temperature
  voltage *= temperatureEffect(rawTemperature);
  
  // Use the discharge curve to determine SOC.
  float stateOfCharge = dischargeCurve(voltage);

  // For realistically simulating an EV battery, you'd also account for current draw and other factors here.

  // Transmit data via Serial
  Serial.print("Battery Voltage: "); Serial.print(voltage); Serial.println("V");
  Serial.print("State Of Charge: "); Serial.print(stateOfCharge); Serial.println("%");
  Serial.print("Temperature: "); Serial.print((rawTemperature / 1023.0) * 50.0); Serial.println("°C");
  
  // Delay between readings.
  delay(500);
}

// Function to send data over CAN
void sendCanMessage(unsigned long id, unsigned char *data, unsigned char length) {
  if(CAN.sendMsgBuf(id, 0, length, data) == CAN_OK) {
    Serial.print("Message sent with ID: ");
    Serial.println(id);
  } else {
    Serial.println("Error sending message");
  }
}
