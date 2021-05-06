import axios from 'axios';
import Lista from "../Components/Lista/Lista"
import "../sass/Listas.scss"
import React, {useEffect, useState} from "react";
import Navigation from "../Components/Navigation/navigation"
import "../sass/navigation.scss"
import "../sass/form.scss"
export default function Usuarios(){
 const[name, setName]=useState('');
  const[contraseña, setContraseña] = useState('');
  const administrativo ="si";
  const contribuidor= true;
    const [personas, setPersonas] = useState([])
const [id, setId] = useState([]);


useEffect(() => { axios.get('https://localhost:44398/api/personas')
            .then(res => {
                setPersonas(res.data)
            })
}, []);


const HandleSubmit=(e)=>{
     e.preventDefault();
    
      console.log("SUBMIT");
      const article = { nombre:name, contraseña:contraseña, administrador:administrativo, contribuidor:contribuidor };
  // Simple POST request with a JSON body using fetch
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(article)
    };
    fetch('https://localhost:44398/api/personas', requestOptions)
        .then(response => response.json())
        .then(data => setId(data.id));
      
       setName('');
      setContraseña('');
    
  }; 



return <section className="cancion">
    <Navigation/>
<h1 className="cancion__title">Usuarios</h1>
<ul className="cancion__lista">
        {personas.map((personas)=>{
            console.log(personas.id);
            return <Lista key={personas.id} {...personas} />
        })}
</ul>

<br/><br/>
<h1 className="cancion__title">Agregar Usuarios</h1>
<article className="form">
   <form className="form__control"  onSubmit={HandleSubmit}>
      <div className="form-control-div">
        <label className="form__label"htmlFor="firstName">Name: </label>
        <input className="form__input" type="text" id="name" name="name"
        value={name} onChange={(e)=> setName(e.target.value)}/>
      </div>
    
    
      <div className="form__control-div">
        <label className="form__label" htmlFor="contraseña">contraseña </label>
        <input className="form__input" type="text" id="contraseña" name="contraseña"
        value={contraseña} onChange={(e)=> setContraseña(e.target.value)}/>
      </div>
      <button className="btn btn--purple btn--animated" type="submit">agregar</button>
    </form>


 </article>
 </section>

}