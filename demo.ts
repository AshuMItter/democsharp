 
//  function DetailsOne(id:number = 45,name:string){
  
//  }

 function calculate_discount(price:number=34,rate:number = 0.50) { 
     var discount = price * rate; 
     console.log("Discount Amount: ",discount); 
  } 

calculate_discount();
//  var n:number = 10;

//  do { 
//     console.log(n); 
//     n--; 
//  } while(n<=0); 


// var num1:number = 2.33;

// //Math.ceil(num1)
// console.log(Math.floor(num1));



// var num:number = 5; 
//  var factorial:number = 1; 

//  while(num >=1) { 
//     factorial = factorial * num; 
//     num--; 
//  } 
//  console.log("The factorial  is "+factorial);  







// var num:number = 0;
//  for(num = 1;num <= 10;num++) {
//    console.log(num);
// }










// var greeting:string = "Joe,Reeta,Arun,Kailash,Keerti";

// var age:number = 34.67;

// var is$Fine:boolean = false;


// var anyname:any = false;
// console.log(greeting.charAt(4));
















// var global_num = 45;
// var str = "1";

// var str2:number = <number> <any> str;

// var nme:string = "Hello World";

// console.log(nme.replace("Hello","Hi"));
// console.log(!(10 > 20));
// console.log(typeof(str2));

  /// conditions
//  var num:number = 2 
//  if(num > 2) { 
//     console.log(num+" is positive") 
//     if(true){
//         console.log("nested if.. ");
//     }
//     else{
//         console.log("nested else..");
//     }
//  } 
//  else { 
//     console.log(num+" is negative") 
//  }

// var data:any = 34;


//   var isUpper:boolean ; 
//  switch(isUpper) { 
//      case true: { 
//        console.log("upper".toUpperCase());
//         break; 
//      } 
//      case false: { 
//         console.log("upper".toLowerCase());
//         break; 
//      } 
//      default: { 
//         console.log("it is anything other than Thirty Four");
//         break; 
//      } 
//   } 

//   console.log(isUpper);

// if(true){
// console.log(true);
// }
// else{
// console.log(false);
// }

// // loops
// // for
// var num:number = 5; 
// var i:number; 
// var factorial:number = 1; 
 


// // loops
// // while

//  var num:number = 5; 
//  var factorial:number = 1; 

//  while(num >=1) { 
//     factorial = factorial * num; 
//     num--; 
//  } 
//  console.log("The factorial  is "+factorial);  

// //loops
// // dowhile
// var n:number = 10;
// do { 
//    console.log(n); 
//    n--; 
// } while(n>=0); 


// // functions

// function Details(id:number){

// }
// // optional parameters
// // no value = undefined

// function DetailsOne(id?:number){

// }

// // rest parameters - ...num:string[]
// // data type must be set to an array.

// function RestDemo(...num:string[]){
//  console.log(num);
//  }
//  RestDemo("abc","abc","abc","abc");

// // default parameters
// function calculate_discount(price:number,rate:number = 0.50) { 
//     var discount = price * rate; 
//     console.log("Discount Amount: ",discount); 
//  } 
// // anonymous function
// var res = function(a:number,b:number) { 
//     return a*b;  
//  }; 
//  console.log(res(12,2));

//  // self calling functions
//  (function () { 
//     var x = "Hello!!";   
//     console.log(x)     
//  })()  

//  // lambda expression
//  var foo = (x:number)=>10 + x 
// console.log(foo(100)) 

// // lambda statment
// var foo:number = (x:number)=> {    
//     x = 10 + x 
//     console.log(x)  
//  } 
//  foo(100)

//  //The data type of the parameter

// function disp(string):void; 
// function disp(number):void;
// //The number of parameters

// function disp(n1:number):void; 
// function disp(x:number,y:number):void;

// //The sequence of parameters

// function disp(n1:number,s1:string):void; 
// function disp(s:string,n:number):void;

//   var abc = 56;
  
// // arrays
// var alphas:string[]; 
// alphas = ["1","2","3","4"] 
// console.log(alphas[0]); 
// console.log(alphas[1]);

// // arrays
// var nums:number[] = [1,2,3,3] 
// console.log(nums[0]); 
// console.log(nums[1]); 
// console.log(nums[2]); 
// console.log(nums[3]);

// var union : number|string|null|string[]
// union = 45;
// union = "mary";
// union = null;

// console.log(union);

// arrays
// var multi:number[][] = [[1,2,3],[23,24,25]]  
// console.log(multi[0][0]) 
// console.log(multi[0][1]) 
// console.log(multi[0][2]) 
// console.log(multi[1][0]) 
// console.log(multi[1][1]) 
// console.log(multi[1][2])

// interfaces
// interface IPerson { 
//     firstName:string, 
//     lastName:string, 
//     sayHi: ()=>string 
//     hello:() => number
//     names:string[]
//  }

//  var customer:IPerson = { 
//    firstName:"Ameet",
//    lastName:"Singh", 
//    sayHi: ():string =>{return "Hi there"},
//    hello: ():number => {return },
//    names: new Array("ashu","pashu")
// }
// console.log("Customer Object ") 
// console.log(customer.firstName) 
// console.log(customer.lastName) 
// console.log(customer.sayHi()) 

// class Car { 
//     //field 
//     engine:string; 
  
//     //constructor 
//     constructor(engine:string) { 
//         // this refers to the current instance 
//        this.engine = engine 
//     }  
 
//     //function 
//     disp():void { 
//        console.log("Engine is  :   "+this.engine) 
//     } 
//  }
//  var obj = new Car("500CC");
//  obj.disp();

// class Shape { 
//     Area:number 
    
//     constructor(a:number) { 
//        this.Area = a 
//     } 
//  } 

 // multiple inheritance supported by Interfaces
//  interface IOne{
//   num: number
//  }

//  interface ITwo{
//      num1:number
// }
//  class Rectangle implements IOne, ITwo{
//      num: number;
//      num1: number;

//  }
 

// objects
// var person = {
//     firstName:"Tom", 
//     lastName:"Hanks", 
//     sayHello:function() {  }  //Type template 
//  } 
//  person.sayHello = function() {  
//     console.log("hello "+person.firstName)
//  }  
//  person.sayHello()


// duck -typing
// class Dog {  
//     sound = "barking";  
    
// }  
// class Lion {  
//     sound = "roar" ;
      
// }  
// class Goat {  
//     sound = "bleat";
//     bound= "bloat";
   
//     swim(){  
//         console.log("Cannot Swim!");  
//     }  
// }  

// var dog:Dog = new Lion();

// var lion:Lion = new Goat();
// console.log(lion.sound);





//  class Circle extends Shape { 
//     disp():void { 
//        console.log("Area of the circle:  "+this.Area) 
//     } 
//  }
// namespace Allow{
//     // use export to get it used outsude the namespace
//   export class One{

//     }
//   export  class Two{

//     }
// }