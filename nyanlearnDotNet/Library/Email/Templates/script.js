let accordion = document.getElementById("accordion");

let courseResults =[
    {
        "ResultPercentage": 50,
        "StudentId": null,
        "Student": null,
        "CourseId": null,
        "Course": {
            "Name": "C programming",
            "Description": "<p>C is a general-purpose programming language created by Dennis Ritchie at the Bell Laboratories in 1972.</p>\r\n<p>It is a very popular language, despite being old.</p>\r\n<p>C is strongly associated with UNIX, as it was developed to write the UNIX operating system.</p>",
            "ImagePath": "93c14ee8-92e6-4944-8df5-65c4274e62b4c-tutorial-for-beginners.png",
            "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
            "Instructor": {
                "Name": "mrkyaing",
                "Email": "mrkyaing@gmail.com",
                "Password": "Mrkyaing12345",
                "Position": "Senior",
                "FatherName": "U Ba Kyaw",
                "Address": "MGW",
                "NRC": "5/38490383",
                "Phone": "09763957240",
                "DOB": "2023-06-01T00:00:00",
                "Courses": [
                    {
                        "Name": "Javascript",
                        "Description": "JavaScript (JS) is a lightweight interpreted (or just-in-time compiled) programming language with first-class functions. While it is most well-known as the scripting language for Web pages, many non-browser environments also use it, such as Node.js, Apache CouchDB and Adobe Acrobat.",
                        "ImagePath": "5bb8ca29-3398-4bdc-a55d-42d17a0199faJavaScript_code.png",
                        "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                        "Lessons": null,
                        "Id": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
                        "CreatedDate": "2023-07-09T13:15:25.8507834",
                        "ModifiedDate": "0001-01-01T00:00:00"
                    },
                    {
                        "Name": "Python",
                        "Description": "<p><strong>Python</strong>&nbsp;is a&nbsp;<a title=\"High-level programming language\" href=\"https://en.wikipedia.org/wiki/High-level_programming_language\">high-level</a>,&nbsp;<a title=\"General-purpose programming language\" href=\"https://en.wikipedia.org/wiki/General-purpose_programming_language\">general-purpose programming language</a>. Its design philosophy emphasizes&nbsp;<a title=\"Code readability\" href=\"https://en.wikipedia.org/wiki/Code_readability\">code readability</a>&nbsp;with the use of significant indentation via the&nbsp;<a title=\"Off-side rule\" href=\"https://en.wikipedia.org/wiki/Off-side_rule\">off-side rule.</a><sup id=\"cite_ref-AutoNT-7_34-0\"></sup></p>\r\n<p>Python is&nbsp;<a title=\"Type system\" href=\"https://en.wikipedia.org/wiki/Type_system#DYNAMIC\">dynamically typed</a>&nbsp;and&nbsp;<a title=\"Garbage collection (computer science)\" href=\"https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)\">garbage-collected</a>. It supports multiple&nbsp;<a title=\"Programming paradigm\" href=\"https://en.wikipedia.org/wiki/Programming_paradigm\">programming paradigms</a>, including&nbsp;<a title=\"Structured programming\" href=\"https://en.wikipedia.org/wiki/Structured_programming\">structured</a>&nbsp;(particularly&nbsp;<a title=\"Procedural programming\" href=\"https://en.wikipedia.org/wiki/Procedural_programming\">procedural</a>),&nbsp;<a title=\"Object-oriented programming\" href=\"https://en.wikipedia.org/wiki/Object-oriented_programming\">object-oriented</a>&nbsp;and&nbsp;<a title=\"Functional programming\" href=\"https://en.wikipedia.org/wiki/Functional_programming\">functional programming</a>. It is often described as a \"batteries included\" language due to its comprehensive&nbsp;<a title=\"Standard library\" href=\"https://en.wikipedia.org/wiki/Standard_library\">standard library</a>.<sup id=\"cite_ref-About_35-0\"></sup><sup id=\"cite_ref-36\"></sup></p>",
                        "ImagePath": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa640px-Python.svg.png",
                        "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                        "Lessons": null,
                        "Id": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
                        "CreatedDate": "2023-07-10T23:15:55.8585407",
                        "ModifiedDate": "0001-01-01T00:00:00"
                    }
                ],
                "Lessons": null,
                "UserId": "50b029bf-bd47-4145-93c8-5a0c7f6bcf25",
                "User": null,
                "Id": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                "CreatedDate": "2023-07-09T13:04:02.2161933",
                "ModifiedDate": "0001-01-01T00:00:00"
            },
            "Lessons": null,
            "Id": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
            "CreatedDate": "2023-07-13T23:16:36.0098304",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "InstructorId": null,
        "Instructor": {
            "Name": "mrkyaing",
            "Email": "mrkyaing@gmail.com",
            "Password": "Mrkyaing12345",
            "Position": "Senior",
            "FatherName": "U Ba Kyaw",
            "Address": "MGW",
            "NRC": "5/38490383",
            "Phone": "09763957240",
            "DOB": "2023-06-01T00:00:00",
            "Courses": [
                {
                    "Name": "C programming",
                    "Description": "<p>C is a general-purpose programming language created by Dennis Ritchie at the Bell Laboratories in 1972.</p>\r\n<p>It is a very popular language, despite being old.</p>\r\n<p>C is strongly associated with UNIX, as it was developed to write the UNIX operating system.</p>",
                    "ImagePath": "93c14ee8-92e6-4944-8df5-65c4274e62b4c-tutorial-for-beginners.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
                    "CreatedDate": "2023-07-13T23:16:36.0098304",
                    "ModifiedDate": "0001-01-01T00:00:00"
                },
                {
                    "Name": "Javascript",
                    "Description": "JavaScript (JS) is a lightweight interpreted (or just-in-time compiled) programming language with first-class functions. While it is most well-known as the scripting language for Web pages, many non-browser environments also use it, such as Node.js, Apache CouchDB and Adobe Acrobat.",
                    "ImagePath": "5bb8ca29-3398-4bdc-a55d-42d17a0199faJavaScript_code.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
                    "CreatedDate": "2023-07-09T13:15:25.8507834",
                    "ModifiedDate": "0001-01-01T00:00:00"
                },
                {
                    "Name": "Python",
                    "Description": "<p><strong>Python</strong>&nbsp;is a&nbsp;<a title=\"High-level programming language\" href=\"https://en.wikipedia.org/wiki/High-level_programming_language\">high-level</a>,&nbsp;<a title=\"General-purpose programming language\" href=\"https://en.wikipedia.org/wiki/General-purpose_programming_language\">general-purpose programming language</a>. Its design philosophy emphasizes&nbsp;<a title=\"Code readability\" href=\"https://en.wikipedia.org/wiki/Code_readability\">code readability</a>&nbsp;with the use of significant indentation via the&nbsp;<a title=\"Off-side rule\" href=\"https://en.wikipedia.org/wiki/Off-side_rule\">off-side rule.</a><sup id=\"cite_ref-AutoNT-7_34-0\"></sup></p>\r\n<p>Python is&nbsp;<a title=\"Type system\" href=\"https://en.wikipedia.org/wiki/Type_system#DYNAMIC\">dynamically typed</a>&nbsp;and&nbsp;<a title=\"Garbage collection (computer science)\" href=\"https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)\">garbage-collected</a>. It supports multiple&nbsp;<a title=\"Programming paradigm\" href=\"https://en.wikipedia.org/wiki/Programming_paradigm\">programming paradigms</a>, including&nbsp;<a title=\"Structured programming\" href=\"https://en.wikipedia.org/wiki/Structured_programming\">structured</a>&nbsp;(particularly&nbsp;<a title=\"Procedural programming\" href=\"https://en.wikipedia.org/wiki/Procedural_programming\">procedural</a>),&nbsp;<a title=\"Object-oriented programming\" href=\"https://en.wikipedia.org/wiki/Object-oriented_programming\">object-oriented</a>&nbsp;and&nbsp;<a title=\"Functional programming\" href=\"https://en.wikipedia.org/wiki/Functional_programming\">functional programming</a>. It is often described as a \"batteries included\" language due to its comprehensive&nbsp;<a title=\"Standard library\" href=\"https://en.wikipedia.org/wiki/Standard_library\">standard library</a>.<sup id=\"cite_ref-About_35-0\"></sup><sup id=\"cite_ref-36\"></sup></p>",
                    "ImagePath": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa640px-Python.svg.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
                    "CreatedDate": "2023-07-10T23:15:55.8585407",
                    "ModifiedDate": "0001-01-01T00:00:00"
                }
            ],
            "Lessons": null,
            "UserId": "50b029bf-bd47-4145-93c8-5a0c7f6bcf25",
            "User": null,
            "Id": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
            "CreatedDate": "2023-07-09T13:04:02.2161933",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T23:21:47.3443451",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "ResultPercentage": 220,
        "StudentId": null,
        "Student": null,
        "CourseId": null,
        "Course": {
            "Name": "Javascript",
            "Description": "JavaScript (JS) is a lightweight interpreted (or just-in-time compiled) programming language with first-class functions. While it is most well-known as the scripting language for Web pages, many non-browser environments also use it, such as Node.js, Apache CouchDB and Adobe Acrobat.",
            "ImagePath": "5bb8ca29-3398-4bdc-a55d-42d17a0199faJavaScript_code.png",
            "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
            "Instructor": {
                "Name": "mrkyaing",
                "Email": "mrkyaing@gmail.com",
                "Password": "Mrkyaing12345",
                "Position": "Senior",
                "FatherName": "U Ba Kyaw",
                "Address": "MGW",
                "NRC": "5/38490383",
                "Phone": "09763957240",
                "DOB": "2023-06-01T00:00:00",
                "Courses": [
                    {
                        "Name": "C programming",
                        "Description": "<p>C is a general-purpose programming language created by Dennis Ritchie at the Bell Laboratories in 1972.</p>\r\n<p>It is a very popular language, despite being old.</p>\r\n<p>C is strongly associated with UNIX, as it was developed to write the UNIX operating system.</p>",
                        "ImagePath": "93c14ee8-92e6-4944-8df5-65c4274e62b4c-tutorial-for-beginners.png",
                        "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                        "Lessons": null,
                        "Id": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
                        "CreatedDate": "2023-07-13T23:16:36.0098304",
                        "ModifiedDate": "0001-01-01T00:00:00"
                    },
                    {
                        "Name": "Python",
                        "Description": "<p><strong>Python</strong>&nbsp;is a&nbsp;<a title=\"High-level programming language\" href=\"https://en.wikipedia.org/wiki/High-level_programming_language\">high-level</a>,&nbsp;<a title=\"General-purpose programming language\" href=\"https://en.wikipedia.org/wiki/General-purpose_programming_language\">general-purpose programming language</a>. Its design philosophy emphasizes&nbsp;<a title=\"Code readability\" href=\"https://en.wikipedia.org/wiki/Code_readability\">code readability</a>&nbsp;with the use of significant indentation via the&nbsp;<a title=\"Off-side rule\" href=\"https://en.wikipedia.org/wiki/Off-side_rule\">off-side rule.</a><sup id=\"cite_ref-AutoNT-7_34-0\"></sup></p>\r\n<p>Python is&nbsp;<a title=\"Type system\" href=\"https://en.wikipedia.org/wiki/Type_system#DYNAMIC\">dynamically typed</a>&nbsp;and&nbsp;<a title=\"Garbage collection (computer science)\" href=\"https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)\">garbage-collected</a>. It supports multiple&nbsp;<a title=\"Programming paradigm\" href=\"https://en.wikipedia.org/wiki/Programming_paradigm\">programming paradigms</a>, including&nbsp;<a title=\"Structured programming\" href=\"https://en.wikipedia.org/wiki/Structured_programming\">structured</a>&nbsp;(particularly&nbsp;<a title=\"Procedural programming\" href=\"https://en.wikipedia.org/wiki/Procedural_programming\">procedural</a>),&nbsp;<a title=\"Object-oriented programming\" href=\"https://en.wikipedia.org/wiki/Object-oriented_programming\">object-oriented</a>&nbsp;and&nbsp;<a title=\"Functional programming\" href=\"https://en.wikipedia.org/wiki/Functional_programming\">functional programming</a>. It is often described as a \"batteries included\" language due to its comprehensive&nbsp;<a title=\"Standard library\" href=\"https://en.wikipedia.org/wiki/Standard_library\">standard library</a>.<sup id=\"cite_ref-About_35-0\"></sup><sup id=\"cite_ref-36\"></sup></p>",
                        "ImagePath": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa640px-Python.svg.png",
                        "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                        "Lessons": null,
                        "Id": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
                        "CreatedDate": "2023-07-10T23:15:55.8585407",
                        "ModifiedDate": "0001-01-01T00:00:00"
                    }
                ],
                "Lessons": null,
                "UserId": "50b029bf-bd47-4145-93c8-5a0c7f6bcf25",
                "User": null,
                "Id": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                "CreatedDate": "2023-07-09T13:04:02.2161933",
                "ModifiedDate": "0001-01-01T00:00:00"
            },
            "Lessons": null,
            "Id": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
            "CreatedDate": "2023-07-09T13:15:25.8507834",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "InstructorId": null,
        "Instructor": {
            "Name": "mrkyaing",
            "Email": "mrkyaing@gmail.com",
            "Password": "Mrkyaing12345",
            "Position": "Senior",
            "FatherName": "U Ba Kyaw",
            "Address": "MGW",
            "NRC": "5/38490383",
            "Phone": "09763957240",
            "DOB": "2023-06-01T00:00:00",
            "Courses": [
                {
                    "Name": "C programming",
                    "Description": "<p>C is a general-purpose programming language created by Dennis Ritchie at the Bell Laboratories in 1972.</p>\r\n<p>It is a very popular language, despite being old.</p>\r\n<p>C is strongly associated with UNIX, as it was developed to write the UNIX operating system.</p>",
                    "ImagePath": "93c14ee8-92e6-4944-8df5-65c4274e62b4c-tutorial-for-beginners.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
                    "CreatedDate": "2023-07-13T23:16:36.0098304",
                    "ModifiedDate": "0001-01-01T00:00:00"
                },
                {
                    "Name": "Javascript",
                    "Description": "JavaScript (JS) is a lightweight interpreted (or just-in-time compiled) programming language with first-class functions. While it is most well-known as the scripting language for Web pages, many non-browser environments also use it, such as Node.js, Apache CouchDB and Adobe Acrobat.",
                    "ImagePath": "5bb8ca29-3398-4bdc-a55d-42d17a0199faJavaScript_code.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
                    "CreatedDate": "2023-07-09T13:15:25.8507834",
                    "ModifiedDate": "0001-01-01T00:00:00"
                },
                {
                    "Name": "Python",
                    "Description": "<p><strong>Python</strong>&nbsp;is a&nbsp;<a title=\"High-level programming language\" href=\"https://en.wikipedia.org/wiki/High-level_programming_language\">high-level</a>,&nbsp;<a title=\"General-purpose programming language\" href=\"https://en.wikipedia.org/wiki/General-purpose_programming_language\">general-purpose programming language</a>. Its design philosophy emphasizes&nbsp;<a title=\"Code readability\" href=\"https://en.wikipedia.org/wiki/Code_readability\">code readability</a>&nbsp;with the use of significant indentation via the&nbsp;<a title=\"Off-side rule\" href=\"https://en.wikipedia.org/wiki/Off-side_rule\">off-side rule.</a><sup id=\"cite_ref-AutoNT-7_34-0\"></sup></p>\r\n<p>Python is&nbsp;<a title=\"Type system\" href=\"https://en.wikipedia.org/wiki/Type_system#DYNAMIC\">dynamically typed</a>&nbsp;and&nbsp;<a title=\"Garbage collection (computer science)\" href=\"https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)\">garbage-collected</a>. It supports multiple&nbsp;<a title=\"Programming paradigm\" href=\"https://en.wikipedia.org/wiki/Programming_paradigm\">programming paradigms</a>, including&nbsp;<a title=\"Structured programming\" href=\"https://en.wikipedia.org/wiki/Structured_programming\">structured</a>&nbsp;(particularly&nbsp;<a title=\"Procedural programming\" href=\"https://en.wikipedia.org/wiki/Procedural_programming\">procedural</a>),&nbsp;<a title=\"Object-oriented programming\" href=\"https://en.wikipedia.org/wiki/Object-oriented_programming\">object-oriented</a>&nbsp;and&nbsp;<a title=\"Functional programming\" href=\"https://en.wikipedia.org/wiki/Functional_programming\">functional programming</a>. It is often described as a \"batteries included\" language due to its comprehensive&nbsp;<a title=\"Standard library\" href=\"https://en.wikipedia.org/wiki/Standard_library\">standard library</a>.<sup id=\"cite_ref-About_35-0\"></sup><sup id=\"cite_ref-36\"></sup></p>",
                    "ImagePath": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa640px-Python.svg.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
                    "CreatedDate": "2023-07-10T23:15:55.8585407",
                    "ModifiedDate": "0001-01-01T00:00:00"
                }
            ],
            "Lessons": null,
            "UserId": "50b029bf-bd47-4145-93c8-5a0c7f6bcf25",
            "User": null,
            "Id": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
            "CreatedDate": "2023-07-09T13:04:02.2161933",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:00:19.2793462",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "ResultPercentage": 223.33333333333334,
        "StudentId": null,
        "Student": null,
        "CourseId": null,
        "Course": {
            "Name": "Python",
            "Description": "<p><strong>Python</strong>&nbsp;is a&nbsp;<a title=\"High-level programming language\" href=\"https://en.wikipedia.org/wiki/High-level_programming_language\">high-level</a>,&nbsp;<a title=\"General-purpose programming language\" href=\"https://en.wikipedia.org/wiki/General-purpose_programming_language\">general-purpose programming language</a>. Its design philosophy emphasizes&nbsp;<a title=\"Code readability\" href=\"https://en.wikipedia.org/wiki/Code_readability\">code readability</a>&nbsp;with the use of significant indentation via the&nbsp;<a title=\"Off-side rule\" href=\"https://en.wikipedia.org/wiki/Off-side_rule\">off-side rule.</a><sup id=\"cite_ref-AutoNT-7_34-0\"></sup></p>\r\n<p>Python is&nbsp;<a title=\"Type system\" href=\"https://en.wikipedia.org/wiki/Type_system#DYNAMIC\">dynamically typed</a>&nbsp;and&nbsp;<a title=\"Garbage collection (computer science)\" href=\"https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)\">garbage-collected</a>. It supports multiple&nbsp;<a title=\"Programming paradigm\" href=\"https://en.wikipedia.org/wiki/Programming_paradigm\">programming paradigms</a>, including&nbsp;<a title=\"Structured programming\" href=\"https://en.wikipedia.org/wiki/Structured_programming\">structured</a>&nbsp;(particularly&nbsp;<a title=\"Procedural programming\" href=\"https://en.wikipedia.org/wiki/Procedural_programming\">procedural</a>),&nbsp;<a title=\"Object-oriented programming\" href=\"https://en.wikipedia.org/wiki/Object-oriented_programming\">object-oriented</a>&nbsp;and&nbsp;<a title=\"Functional programming\" href=\"https://en.wikipedia.org/wiki/Functional_programming\">functional programming</a>. It is often described as a \"batteries included\" language due to its comprehensive&nbsp;<a title=\"Standard library\" href=\"https://en.wikipedia.org/wiki/Standard_library\">standard library</a>.<sup id=\"cite_ref-About_35-0\"></sup><sup id=\"cite_ref-36\"></sup></p>",
            "ImagePath": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa640px-Python.svg.png",
            "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
            "Instructor": {
                "Name": "mrkyaing",
                "Email": "mrkyaing@gmail.com",
                "Password": "Mrkyaing12345",
                "Position": "Senior",
                "FatherName": "U Ba Kyaw",
                "Address": "MGW",
                "NRC": "5/38490383",
                "Phone": "09763957240",
                "DOB": "2023-06-01T00:00:00",
                "Courses": [
                    {
                        "Name": "C programming",
                        "Description": "<p>C is a general-purpose programming language created by Dennis Ritchie at the Bell Laboratories in 1972.</p>\r\n<p>It is a very popular language, despite being old.</p>\r\n<p>C is strongly associated with UNIX, as it was developed to write the UNIX operating system.</p>",
                        "ImagePath": "93c14ee8-92e6-4944-8df5-65c4274e62b4c-tutorial-for-beginners.png",
                        "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                        "Lessons": null,
                        "Id": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
                        "CreatedDate": "2023-07-13T23:16:36.0098304",
                        "ModifiedDate": "0001-01-01T00:00:00"
                    },
                    {
                        "Name": "Javascript",
                        "Description": "JavaScript (JS) is a lightweight interpreted (or just-in-time compiled) programming language with first-class functions. While it is most well-known as the scripting language for Web pages, many non-browser environments also use it, such as Node.js, Apache CouchDB and Adobe Acrobat.",
                        "ImagePath": "5bb8ca29-3398-4bdc-a55d-42d17a0199faJavaScript_code.png",
                        "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                        "Lessons": null,
                        "Id": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
                        "CreatedDate": "2023-07-09T13:15:25.8507834",
                        "ModifiedDate": "0001-01-01T00:00:00"
                    }
                ],
                "Lessons": null,
                "UserId": "50b029bf-bd47-4145-93c8-5a0c7f6bcf25",
                "User": null,
                "Id": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                "CreatedDate": "2023-07-09T13:04:02.2161933",
                "ModifiedDate": "0001-01-01T00:00:00"
            },
            "Lessons": null,
            "Id": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
            "CreatedDate": "2023-07-10T23:15:55.8585407",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "InstructorId": null,
        "Instructor": {
            "Name": "mrkyaing",
            "Email": "mrkyaing@gmail.com",
            "Password": "Mrkyaing12345",
            "Position": "Senior",
            "FatherName": "U Ba Kyaw",
            "Address": "MGW",
            "NRC": "5/38490383",
            "Phone": "09763957240",
            "DOB": "2023-06-01T00:00:00",
            "Courses": [
                {
                    "Name": "C programming",
                    "Description": "<p>C is a general-purpose programming language created by Dennis Ritchie at the Bell Laboratories in 1972.</p>\r\n<p>It is a very popular language, despite being old.</p>\r\n<p>C is strongly associated with UNIX, as it was developed to write the UNIX operating system.</p>",
                    "ImagePath": "93c14ee8-92e6-4944-8df5-65c4274e62b4c-tutorial-for-beginners.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
                    "CreatedDate": "2023-07-13T23:16:36.0098304",
                    "ModifiedDate": "0001-01-01T00:00:00"
                },
                {
                    "Name": "Javascript",
                    "Description": "JavaScript (JS) is a lightweight interpreted (or just-in-time compiled) programming language with first-class functions. While it is most well-known as the scripting language for Web pages, many non-browser environments also use it, such as Node.js, Apache CouchDB and Adobe Acrobat.",
                    "ImagePath": "5bb8ca29-3398-4bdc-a55d-42d17a0199faJavaScript_code.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
                    "CreatedDate": "2023-07-09T13:15:25.8507834",
                    "ModifiedDate": "0001-01-01T00:00:00"
                },
                {
                    "Name": "Python",
                    "Description": "<p><strong>Python</strong>&nbsp;is a&nbsp;<a title=\"High-level programming language\" href=\"https://en.wikipedia.org/wiki/High-level_programming_language\">high-level</a>,&nbsp;<a title=\"General-purpose programming language\" href=\"https://en.wikipedia.org/wiki/General-purpose_programming_language\">general-purpose programming language</a>. Its design philosophy emphasizes&nbsp;<a title=\"Code readability\" href=\"https://en.wikipedia.org/wiki/Code_readability\">code readability</a>&nbsp;with the use of significant indentation via the&nbsp;<a title=\"Off-side rule\" href=\"https://en.wikipedia.org/wiki/Off-side_rule\">off-side rule.</a><sup id=\"cite_ref-AutoNT-7_34-0\"></sup></p>\r\n<p>Python is&nbsp;<a title=\"Type system\" href=\"https://en.wikipedia.org/wiki/Type_system#DYNAMIC\">dynamically typed</a>&nbsp;and&nbsp;<a title=\"Garbage collection (computer science)\" href=\"https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)\">garbage-collected</a>. It supports multiple&nbsp;<a title=\"Programming paradigm\" href=\"https://en.wikipedia.org/wiki/Programming_paradigm\">programming paradigms</a>, including&nbsp;<a title=\"Structured programming\" href=\"https://en.wikipedia.org/wiki/Structured_programming\">structured</a>&nbsp;(particularly&nbsp;<a title=\"Procedural programming\" href=\"https://en.wikipedia.org/wiki/Procedural_programming\">procedural</a>),&nbsp;<a title=\"Object-oriented programming\" href=\"https://en.wikipedia.org/wiki/Object-oriented_programming\">object-oriented</a>&nbsp;and&nbsp;<a title=\"Functional programming\" href=\"https://en.wikipedia.org/wiki/Functional_programming\">functional programming</a>. It is often described as a \"batteries included\" language due to its comprehensive&nbsp;<a title=\"Standard library\" href=\"https://en.wikipedia.org/wiki/Standard_library\">standard library</a>.<sup id=\"cite_ref-About_35-0\"></sup><sup id=\"cite_ref-36\"></sup></p>",
                    "ImagePath": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa640px-Python.svg.png",
                    "InstructorId": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
                    "Lessons": null,
                    "Id": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
                    "CreatedDate": "2023-07-10T23:15:55.8585407",
                    "ModifiedDate": "0001-01-01T00:00:00"
                }
            ],
            "Lessons": null,
            "UserId": "50b029bf-bd47-4145-93c8-5a0c7f6bcf25",
            "User": null,
            "Id": "cca0f286-79cf-42ec-955d-657ce37cb1ef",
            "CreatedDate": "2023-07-09T13:04:02.2161933",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:36:38.9032269",
        "ModifiedDate": "0001-01-01T00:00:00"
    }
];

let lessonResults = [
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 83.33333333333334,
        "Lesson": {
            "Name": "Basic Operators",
            "Description": "<h3>Arithmetic Operators</h3>\r\n<p>Just as any other programming languages, the addition, subtraction, multiplication, and division operators can be used with numbers.</p>\r\n<div data-height=\"184\" data-lang=\"python\">\r\n<div>\r\n<div>\r\n<div>\r\n<ul style=\"list-style-type: none;\">\r\n<li style=\"list-style-type: none;\">&nbsp;</li>\r\n</ul>\r\n</div>\r\n</div>\r\n</div>\r\n</div>",
            "CourseName": "Python",
            "FilePath": "https://i0.wp.com/makemeanalyst.com/wp-content/uploads/2017/06/Relational-Operators-in-Python.png",
            "CourseId": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
            "Courses": null,
            "Id": "0b74fced-a72c-44a4-9d23-5b04e95f4886",
            "CreatedDate": "2023-07-10T23:23:17.3979791",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:39:10.2210153",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 80,
        "Lesson": {
            "Name": "Variables and Types",
            "Description": "<p>Python is completely object oriented, and not \"statically typed\". You do not need to declare variables before using them, or declare their type. Every variable in Python is an object.</p>",
            "CourseName": "Python",
            "FilePath": "https://images.theengineeringprojects.com/image/main/2020/06/Datatypes-in-python.jpg",
            "CourseId": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
            "Courses": null,
            "Id": "9fa69b1b-157b-49b9-8e88-4bb984b0d184",
            "CreatedDate": "2023-07-10T23:18:59.2932762",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:40:02.5745184",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 80,
        "Lesson": {
            "Name": "JavaScript Variables",
            "Description": "<p>JavaScript Variables can be declared in 4 ways:</p>\r\n<ul>\r\n<li>Automatically</li>\r\n<li>Using&nbsp;<code>var</code></li>\r\n<li>Using&nbsp;<code>let</code></li>\r\n<li>Using&nbsp;<code>const</code></li>\r\n</ul>",
            "CourseName": "Javascript",
            "FilePath": "https://www.learnsimpli.com/wp-content/uploads/2019/09/javascript-data-types.png",
            "CourseId": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
            "Courses": null,
            "Id": "0e2862d1-45aa-4210-bfe6-5938b39fafc0",
            "CreatedDate": "2023-07-10T23:20:35.3902936",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:00:44.4007952",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 60,
        "Lesson": {
            "Name": "JavaScript Operators",
            "Description": "<p>The&nbsp;<strong>Addition Operator</strong>&nbsp;<strong>+</strong>&nbsp;adds numbers:</p>\r\n<p>The&nbsp;<strong>Assignment Operator</strong>&nbsp;<strong>=</strong>&nbsp;assigns a value to a variable.</p>\r\n<p>&nbsp;</p>",
            "CourseName": "Javascript",
            "FilePath": "https://www.w3schools.com/js/img_operators.jpg",
            "CourseId": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
            "Courses": null,
            "Id": "a1053942-2b50-4fe6-8f8a-2d38f275113a",
            "CreatedDate": "2023-07-10T23:21:33.6797332",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:35:29.2431579",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 60,
        "Lesson": {
            "Name": "Lists",
            "Description": "<p>Lists are very similar to arrays. They can contain any type of variable, and they can contain as many variables as you wish. Lists can also be iterated over in a very simple manner. Here is an example of how to build a list.</p>",
            "CourseName": "Python",
            "FilePath": "https://www.programiz.com/sites/tutorial2program/files/python-list-index.png",
            "CourseId": "f4a31bf3-4f1b-4036-8687-b76d7232d4aa",
            "Courses": null,
            "Id": "eb1bb8a4-facb-43ad-9870-fd67a6ecb395",
            "CreatedDate": "2023-07-10T23:22:27.4635751",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:41:17.0477695",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 80,
        "Lesson": {
            "Name": "JavaScript Variables",
            "Description": "<p>JavaScript Variables can be declared in 4 ways:</p>\r\n<ul>\r\n<li>Automatically</li>\r\n<li>Using&nbsp;<code>var</code></li>\r\n<li>Using&nbsp;<code>let</code></li>\r\n<li>Using&nbsp;<code>const</code></li>\r\n</ul>",
            "CourseName": "Javascript",
            "FilePath": "https://www.learnsimpli.com/wp-content/uploads/2019/09/javascript-data-types.png",
            "CourseId": "5bb8ca29-3398-4bdc-a55d-42d17a0199fa",
            "Courses": null,
            "Id": "0e2862d1-45aa-4210-bfe6-5938b39fafc0",
            "CreatedDate": "2023-07-10T23:20:35.3902936",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T22:36:32.6413296",
        "ModifiedDate": "0001-01-01T00:00:00"
    },
    {
        "Name": null,
        "StudentId": null,
        "LessonId": null,
        "ResultPercentage": 50,
        "Lesson": {
            "Name": "C Variables",
            "Description": "<p>Variables are containers for storing data values, like numbers and characters.</p>\r\n<p>In C, there are different&nbsp;<strong>types</strong>&nbsp;of variables (defined with different keywords), for example:</p>\r\n<ul>\r\n<li><code>int</code>&nbsp;- stores integers (whole numbers), without decimals, such as&nbsp;<code>123</code>&nbsp;or&nbsp;<code>-123</code></li>\r\n<li><code>float</code>&nbsp;- stores floating point numbers, with decimals, such as&nbsp;<code>19.99</code>&nbsp;or&nbsp;<code>-19.99</code></li>\r\n<li><code>char</code>&nbsp;- stores single characters, such as&nbsp;<code>'a'</code>&nbsp;or&nbsp;<code>'B'</code>. Char values are surrounded by&nbsp;<strong>single quotes</strong></li>\r\n</ul>",
            "CourseName": "C programming",
            "FilePath": "https://cdn.educba.com/academy/wp-content/uploads/2019/10/Variables-in-C.png",
            "CourseId": "93c14ee8-92e6-4944-8df5-65c4274e62b4",
            "Courses": null,
            "Id": "15691db3-4b13-4f6c-a2a9-2604b66e481d",
            "CreatedDate": "2023-07-13T23:19:04.9187302",
            "ModifiedDate": "0001-01-01T00:00:00"
        },
        "Id": null,
        "CreatedDate": "2023-07-13T23:22:09.366117",
        "ModifiedDate": "0001-01-01T00:00:00"
    }
];







