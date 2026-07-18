# TechHire CLI Screening System

An interactive, command-line based recruitment management utility and candidate screening system built entirely in C# using .NET Core. This project serves as a practical demonstration of core software engineering methodologies, strict Object-Oriented Programming (OOP) paradigms, and algorithmic problem-solving using fundamental Data Structures and Algorithms (DSA).

---

## 🚀 Core Architectural Highlights

This application is engineered cleanly to showcase three primary technical layers:
1. **Dynamic Interactive UI:** Driven entirely by interactive user console input, continuous application state loops, and granular conditional execution layers.
2. **Strict Object-Oriented Blueprint (OOP):** Focuses heavily on data encapsulation and modular class construction to isolate data models from structural management logic.
3. **Data Structures & Algorithms (DSA):** Bypasses reliance on high-level built-in LINQ methods to implement manual, low-level linear searches and sorting structures directly on collection datasets.

---

## 🛠️ Key Technical Implementations

### 1. Object-Oriented Programming (OOP) & Design
* **Encapsulated Models:** The `Candidate` model shields properties securely, initializing states exclusively through parameterized constructors.
* **Component Reusability:** Features a dedicated `DisplayCandidateInfo()` routine, ensuring structured, decoupled, and reusable code execution blocks.

### 2. Control Flow & Data Operations
* **Continuous System Loop:** Utilizes an efficient `while` condition block to maintain terminal interface states during intensive workflows.
* **Input Validation Layers:** Integrates standard terminal reading logic coupled with explicit `if-else` branching vectors to parse dynamic system commands safely.

### 3. Data Structures & Algorithmic Mechanics (DSA)
* **Linear Array/Collection Search (Filtering):** Implements a dedicated element matching engine that searches complex string instances sequentially across records in $O(N)$ runtime complexity.
* **In-Place Bubble Sort (Ranking Metric):** Implements a low-level, manual **Bubble Sort Algorithm** to dynamically sort objects in memory based on a floating-point property (`CGPA`) in descending order, executing structural data swaps seamlessly without external framework abstractions.

---

## 💻 Technical Breakdown of the Code Structure

* **Language/Framework:** C# / .NET Core CLI Application
* **Concepts Utilized:**
  * Memory Tracking via Collections (`List<T>`)
  * Data Type Conversions & Safe Console Parsing
  * In-place Sorting Mechanics
  * Iterative Dataset Enumerations (`foreach` / `for` loops)

---

## ⚙️ How to Execute the Project Locally

1. Ensure you have the **.NET SDK** installed on your workstation.
2. Clone or download the source repository files:
   git clone https://github.com/AhmedMuhammad15/TechHire-CLI-Screening-System.git
