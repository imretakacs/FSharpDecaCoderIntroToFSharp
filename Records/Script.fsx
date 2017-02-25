let person = ("Mark", "Gray","Man Utd", 22)

type Person = {
   firstName: string
   lastName: string
   favClub: string
   myAge: int}

let me = {
   firstName="Mark"
   lastName="Gray"
   favClub="Man Utd"
   myAge=22}

let {firstName=myFirstname} = me
let {lastName=myLastname} = me
let {myAge=myAge} = me
let {favClub=favClub} = me

let myFullName = me.firstName + " " + me.lastName 

me

let temp = { me with myAge = 30}

me