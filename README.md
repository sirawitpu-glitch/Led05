# Led05
นายสิรวิชญ ภูต้องใจ รหัส 683450063-2

classDiagram
    class Person {
        <<abstract>>
        - FirstName : string
        - LastName  : string
        - Phone     : string
        - Email     : string
        + Register() : void
        + ShowInfo() : void
    }

    class ISpeaker {
        <<interface>>
        + Train() : void
        + Approve(p : Person) : void
    }

    class Student {
        Person
        + ShowInfo() : void
    }

    class Teacher {
        Person
        + ShowInfo() : void
        + Train() : void
    }

    class GeneralPerson {
        Person
        - Workplace : string
        - Position  : string
        + ShowInfo() : void
        + Train() : void
        + Approve(p : Person) : void
    }

    Person <|-- Student : s1
    Person <|-- Teacher : s2
    ISpeaker <|-- GeneralPerson : s3
