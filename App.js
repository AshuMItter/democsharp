import logo from './logo.svg';
import React from 'react';
import './App.css';
import SecondComponent  from './second';
 



class App extends React.Component{

  constructor(){
    super();
    this.state = {name :" "};
    this.handevent = this.handevent.bind(this);
    this.handlechange = this.handlechange.bind(this);
  }
  handevent(){

    alert(this.state.name);
   
    
  }
  handlechange(e){
    
    
    this.setState({name:"to be set here"})
    
  }

  render(){
    return(
<div>
   <table border="2">
     <tr>
     <td>
         Please enter your User Name.
       </td>
       <td>
         <input type="text" onChange={this.handlechange} ></input>
       </td>
     </tr>
     <tr>
     <td>
         Please enter your Password.
       </td>
       <td>
         <input type="password"></input>
       </td>
     </tr>
     <tr>
    
       <td>
         <button id="btn" onClick={this.handevent}>
           Login
         </button>
       </td>
     </tr>
   </table>
    <SecondComponent /> 
   </div>

  

    );
  }
}


// function App() {
//   return (
//     <div>
//    <table border="2">
//      <tr>
//      <td>
//          Please enter your User Name.
//        </td>
//        <td>
//          <input type="text"></input>
//        </td>
//      </tr>
//      <tr>
//      <td>
//          Please enter your Password.
//        </td>
//        <td>
//          <input type="password"></input>
//        </td>
//      </tr>
//      <tr>
    
//        <td>
//          <button id="btn">
//            Login
//          </button>
//        </td>
//      </tr>
//    </table>
//    </div>
//   );
// }

export default App;
