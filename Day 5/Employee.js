class Employee {
    id;
    firstName;
    lastName;
    email;
    constructor(id, firstName, lastName, email) {
        this.id = id
        this.firstName = firstName
        this.lastName = lastName
        this.email = email
    }
}

class Book {
    id;
    name;
    author;
    constructor(id, name, author) {
        this.id = id
        this.name = name
        this.author = author
    }
}

class Allotment {
    book;
    emp;
    constructor(book, emp) {
        this.book = book
        this.emp = emp
    }
}

class Librarian {
    allotments;
    constructor(EmployeeList, BookList) {
        this.EmployeeList = EmployeeList;
        this.BookList = BookList;
        this.allotments = []
    }
    allotBook(book, employee) {
        console.log("alloting...")
        this.BookList.forEach(b => {
            if (b.name === book) {
                this.EmployeeList.forEach(e => {
                    console.log(e)
                    if (e.firstName === employee) {
                        console.log(e.id)
                        this.allotments.push(new Allotment(
                            {
                                'bookID':b.id,
                                'name':b.name
                            },
                            {
                                'empID':e.id,
                                'email':e.email
                            }
                        )
                    )}
                })
            }
        });
    }
    getAllotments() {
        this.allotments.forEach(element => {
            console.log(element)
        })
    }

}

Employee1 = new Employee(1, "Anandu", "R", "ananduraj32gmail.com")
Employee2 = new Employee(1, "Aqua", "regis", "aqua@regis")

Book1 = new Book(1, "Helbringers' Quest", "Unknown")

Employees = [
    Employee1, Employee2
]
Books = [Book1]

librarian = new Librarian(EmployeeList = Employees, BookList = Books)
librarian.allotBook("Helbringers' Quest", "Anandu")

librarian.getAllotments()

// for(let i = 0; i < input)