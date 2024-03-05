# Assignment-1-SD6502
Learning Commons (library) at WelTec needs software to manage borrowing and returns activities. The
library offers books, articles, digital media among others for staffs and students to borrow. Staff can have
any numbers of borrowings but can only keep for a calender year. Staffs have no limitation on the number
of renewals. Students can have a maximum of 5 borrowings per trimester. Only one renewal is allowed for
students after the expiration period of each borrowings. They have a strict $5 per day penalty if the items
borrowed are not returned (or renewed) on time.
1.1 Part 1: Design
(a) Identify classes (4 or more), methods (messages) and attributes. Show all the steps involved. Give
reason for your choices of class and methods. [10 Marks]
(b) List CRC cards for each class (es) you identified. [5 Marks]
(c) Give Class diagram. [5 Marks]
1.2 Part 2: Implementation
1.2.1 Task 1:
Implement your design using C# (console app). At a minimum, your implementation should have following
functionalities,
(a) Adding/removing library contents (books, articles, digital media. . . ). [12 Marks]
(b) Listing all the contents (possibly by category (books, articles, digital media. . . )). [12 Marks]
(c) Display a list of borrowings for a staff or student. Calculate and display penalty (if any). [12 Marks]
Further, 12 marks are allocated for the application of following concepts, where feasible, (such as:
modularity, inheritance, polymorphism, method overriding and overloading, collections- 2 marks for each
concept).
Note: You are free to assume or fill gaps in the textual description that you think will make your design/implementation better/easier.

1.3 Task 2:
[32 Marks]
For this task there are two files given in the supplementary files folder unsorted data.csv and sorted data.csv.
(a) Assume that you have all the lastnames of staffs/students available from the Task 1 and you have
saved the data in a file unsorted data.csv. Write a C# console program to search a given string
Lastname from the given file using sequential search algorithm. [5 Marks]
(b) Assume that you have all the lastnames of staffs/students available and you have saved the data in a
file sorted data.csv. Write a C# console program to search a given string Lastname from the given
file using binary search algorithm. [5 Marks]
(c) Search following Lastnames using implementations from above (Task 1a and Task1b). Record and
comment on time taken (Runtime) by each algorithm. [4+2 Marks]

Lastname Sequential Search Runtime Binary Search Runtime
Singh
Tauras
Hasha
Dazi

(d) Write a program that sorts all the Firstnames from the file unsorted data.csv using each of the basic sorting algorithms (Insertion, Bubble, Quicksort). Record and comment on time taken (Runtime)
by each algorithm. [4+4+4+4 Marks]
You may use the skeleton code given on supplementary files folder which provides code for measuring
runtime, reading from file and parsing string.
2 Submission
Submission should be done electronically via Moodle (course page): Make separate folders for each of the
tasks –>Zip it into a single folder –>upload to the submission folder on the course page.

References
1. Singh, Manish. Lecture Notes (Slides). http://moodle.weltec.ac.nz
2. John Sharp, Microsoft Visual C# Step by Step, 8th edition. Microsoft Press, ISBN:978-1-5093-0104-1
3. Timothy A Budd, An Introduction to Object-Oriented Programming, ISBN 0-201-76031-2, 2002.
4. Michael McMillan, Data Structures and Algorithms using C#, Cambridge University Press,The Edinburgh Building, Cambridge CB2 8RU, UK