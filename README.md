# GrizzlyWatt
## Inspiration
Electric Vehicles (EVs) are in the new wave of innovation. Designing and monitoring the batteries for these EVs is tough.

## What it does
This program monitors a real-time EV battery system and provides results based on the battery designer's requirements. There are multiple tests that are ran like standard commute and acceleration/deceleration wear on the battery.

## How we built it
Using a C# executable program, users can connect to an EV battery or battery simulator and set specific characteristics for the vehicle. The values are then sent over Control Area Network (CAN) or serial to the battery. The battery then reports back different values ranging from State of Charge (SOC) to a thermal heat map of the battery cells.

## Challenges we ran into
Simulating a battery management system involves a lot of electrochemical, electrical, and thermodynamic understanding to simulate an EV battery. Getting the UI to report and properly display information from the battery was a challenge too. The use of Kitone is good for sending the results to the database for data analysis in the future.

## Accomplishments that we're proud of
We are proud of developing an application that simulates so much. Learning about the characteristics of an EV battery and how different parameters affect the battery's performance.

## What we learned
We learned how to interface with our hardware and display lots of information from the battery simulator to the C# program.

## What's next for Grizzly Watt
We hope to continue to refine the UI and work with larger, more powerful battery or full vehicle. simulators
