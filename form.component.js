import { useState, useRef, useEffect} from 'react';

export default function Form(){

  const [name, setName] = useState("");
   const [email, setEmail] = useState("");
   const [continent, setCon] = useState("");
   const [range, setRnge] = useState("");
   const [error,setError] = useState("");
   const [ok, setOk] = useState(false);
   const [dte, setdte] = useState(false);
   const nameVal = useRef("");
   const emailVal = useRef("");
   const fileUp = useRef("");
   
    function onSubmit(e){
        e.preventDefault();
        
    
    //    alert(name);
    //    alert(email);
    //    alert(continent);
       var data ={
           name:name,
           email:email,
           continent:continent,
           ok:ok,
           dte:dte,
           rageOf:range,
          
       }
       alert(JSON.stringify(data));
       

    }
    var list=[];
    useEffect(() => {
        // Logs `HTMLInputElement` 
        console.log(nameVal.current);
        nameVal.current.focus();
        

      
      },[]);
    
    function setthisName(e){
        setName(e.target.value);
          var res =Number.parseInt(e.target.value);
          if(res % 2 != 0){
             setError("Not divisble by 2! Please put valid value");
          }
          else{
              setError("");
          }
      
    }

    function setthisEmail(e){
        setEmail(e.target.value);

    }

    function setContinent(e){
    setCon(e.target.value);
    
    }
    function setInput(e){
       if(e.target.checked == true){
    setOk(e.target.value);
       }
    }
    function setDate(e){
        alert(e.target.value)
     setdte(e.target.value);
    }

    function setRange(e){
      //  alert(e.target.value)
setRnge(e.target.value);
    }
    

    return(
       <>
      
     <form onSubmit={onSubmit}>
     
      <input type="text"  name="name" ref={nameVal} onChange={setthisName}  required />
    <p style={{color:'red'}}> {error}</p> <br />
      <input type="email" name="email" onChange={setthisEmail} ref={emailVal}  required /><br />
      <input type="number" max="120" min="18"></input><br />
      <select onChange={setContinent}>
          <option value="Asia">
              Asia
          </option>
          <option value="Africa">
              Africa
          </option>
          <option value="SA">
              South America
          </option>
          <option value="NA">
              North America
          </option>
          <option value="Europe">
              Europe
          </option>
          <option value="Antarctica">
              Antarctica
          </option>
          <option value="Australia">
             Australia
          </option>
          
      </select> <br />
     
      <input type="checkbox" value="Ok" onChange={setInput}/> <br />
      <input type="date" onChange={setDate}></input> <br />
      <input type="range" onChange={setRange} min="0" max="10"></input> <br />
      <p>{range}</p> <br />
      <input type="submit" className="btn btn-primary" value="Submit" />
      
      
    </form>
    
       </>

    )
}