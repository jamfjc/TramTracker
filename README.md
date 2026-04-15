# TramTracker(Project/Stage Name)
A C# console application that simulates tram passenger tracking across multiple stations. Given the number of passengers boarding and alighting at each stop, it calculates the total number of passengers who travelled and identifies the station with the highest number of boardings.

# Tram Passenger Tracker(Project Design)

A C# console application that simulates passenger flow on a tram route.
For each station, it reads how many passengers board and alight, then outputs
the total number of passengers who travelled and the station where the most
passengers boarded.

---

## How It Works

The program reads the number of stations, then for each station reads two values —
passengers getting on and passengers getting off. It accumulates the total boardings
across all stations and tracks which station had the single highest number of
passengers boarding.

---

## Input Format
N
on1 off1
on2 off2

- `N` — number of stations
- `on` — passengers boarding at that station
- `off` — passengers alighting at that station

---

## Output Format
totalPassengers
stationIndex

- Line 1 — total number of passengers who boarded across all stations
- Line 2 — the 1-based index of the station with the most boardings

---

## Example
Input: Output:
4 18
3 0 2
7 2
5 4
3 6

Station boardings: 3, 7, 5, 3 — most boardings at station 2 → total 18, station 2

<img width="487" height="203" alt="image" src="https://github.com/user-attachments/assets/0be9ce92-ba97-4afe-bfdc-67dc2ad7f740" />

---

## Project Structure
Prog 01/
├── Program.cs # Main logic — passenger tracking and station analysis
├── tramtram.csproj # .NET project file
└── tramtram.sln # Solution file

---

## Built With

- C# / .NET
- Standard console I/O

