# STM32 Industrial Measurement and Control System

[![Language](https://img.shields.io/badge/Language-C-blue.svg)](https://en.wikipedia.org/wiki/C_(programming_language))
[![Platform](https://img.shields.io/badge/Platform-STM32-orange.svg)](https://www.st.com/en/microcontrollers-microprocessors/stm32f103c8.html)
[![Interface](https://img.shields.io/badge/GUI-C%23-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-lightgrey.svg)](LICENSE)

## Project Overview

This project demonstrates the application of the **STM32F103C8T6 (Blue Pill)** microcontroller in industrial measurement and control systems. It implements a variety of standard industrial communication protocols to interface with external peripherals, sensors, and actuators.

The system features a **Windows Forms (C#)** host application that communicates with the STM32 via UART/USB, allowing for real-time monitoring, control, and data visualization.

**Course:** Measurement and Control using Computer (HCMUT)
**Author:** LongvoTheEngineer

## Key Features

* **Multi-Protocol Communication:** Implementation of UART, SPI, I²C, USB (CDC), and Parallel Interface.
* **PID Motor Control:** Closed-loop speed and position control of a DC Geared Motor using an encoder and PID algorithm.
* **Data Storage:** External EEPROM interfacing via I²C for non-volatile data storage.
* **Analog/Digital Conversion:** * **DAC:** Digital-to-Analog conversion using MCP4725 (I²C).
* **ADC:** Reading industrial sensors (Loadcell/Pt100) and 4-20mA loops.
* **HMI/Display:** 7-Segment LED display control via SPI (MAX7219).
* **External Memory Expansion:** Interfacing with CY6264 SRAM via parallel communication.
* **Digital I/O Isolation:** Industrial standard inputs/outputs using Optocouplers.

## Hardware Architecture

The system is built around the STM32F103C8T6 using the following components:

| Component | Function | Protocol |
| :--- | :--- | :--- |
| **STM32F103C8T6** | Main CPU (Blue Pill) | - |
| **GA25-370 Motor** | DC Geared Motor (with Encoder) | PWM / GPIO |
| **L298N** | Motor Driver | GPIO |
| **MCP4725** | DAC (Digital to Analog) | I²C |
| **AT24C256** | EEPROM Storage | I²C |
| **MAX7219** | 7-Segment Display Driver | SPI |
| **CY6264** | External SRAM (8KB) | Parallel |
| **TLP281** | Optocoupler (Isolation) | Digital I/O |
| **CP2102** | USB-to-TTL Converter | UART |

## Software & Tools

* **Firmware Development:** Keil uVision V5 / STM32CubeMX
* **Host Application:** Microsoft Visual Studio (C# Windows Forms)
* **Debugging:** ST-Link V2

## Communication Protocol Frame

The communication between the PC and STM32 follows a strict custom data frame structure to ensure data integrity across different modes.

**Frame Format:**
`[Start Byte] [Mode] [Action] [Reserved] [Stop Byte]`

### Mode Definitions

| Mode ID | Description | Functionality |
| :---: | :--- | :--- |
| **00** | Control LED | Toggle LEDs via UART commands. |
| **01** | Motor Position | Control motor angle (45°, 90°, 180°, 360°). |
| **02** | Pulse Transfer | Active/Inactive pulse graph visualization. |
| **03** | Status Tracking | Monitor LED and Motor states. |
| **04** | Motor Speed | Open/Closed loop speed control. |
| **05** | Data Storage | Store LED status & Motor speed to EEPROM. |
| **06** | DAC Control | Set output voltage (0-3V). |
| **07** | 7-Segment Display | Send numerical data to display via SPI. |
| **08** | Digital I/O | Read/Write to isolated Digital I/O ports. |
| **09** | ADC Reading | Read analog signals (e.g., Loadcell/Pt100). |
| **10** | External RAM | Read/Write test for external SRAM. |

## PID Control Implementation

The project implements a PID controller for the DC motor to ensure precise positioning and speed stability.
* **Feedback:** Quadrature Encoder.
* **Output:** PWM duty cycle adjustment.
* **Tuning:** Kp, Ki, Kd parameters adjustable via code/GUI.

## Pin Configuration (Summary)

* **I²C (EEPROM/DAC):** PB6 (SCL), PB7 (SDA)
* **SPI (Display):** PB13 (SCK), PB15 (MOSI), PB12 (CS)
* **UART (PC Comm):** PA9 (TX), PA10 (RX)
* **Motor PWM:** TIM1_CH1
* **Parallel SRAM:** PA0-PA7 (Data), PB0-PB2 (Control)

## Screenshots & Results

<img width="1200" height="933" alt="image" src="https://github.com/user-attachments/assets/0e892706-a501-4a6c-afa4-88b831a26d24" />

* **GUI Interface:** Shows real-time graphing of motor position and control panels.
* **Hardware Setup:** Wiring of the STM32 with industrial modules.

## License

This project is open-source and available under the [MIT License](LICENSE).
