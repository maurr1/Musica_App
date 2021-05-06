import React, { useState, useContext } from 'react';

import axios from 'axios';

const PersonasContext = React.createContext();


export default function Persona(cancion){

    const removePerson =(e)=>{
        console.log("Whats " +e)
       fetch(`https://localhost:44398/${e}`, {
          
  method: 'DELETE',
  headers: {
    'Content-Type': 'application/json'
  },
  body: null  //if you do not want to send any addional data,  replace the complete JSON.stringify(YOUR_ADDITIONAL_DATA) with null
})
}


    return <li className="cancion__item">
    <img src={cancion.imagen || "https://pluspng.com/img-png/user-png-icon-young-user-icon-2400.png"} alt="Foto de imagen" className="cancion__photo"/>
    <div className="cancion__info">
        <h3 className="cancion__nombre">{cancion.nombre}</h3> 
    </div>
   <button id={cancion.id} className="btn btn--red btn--animated" onClick={(e)=>removePerson(e.target.id)}>Eliminar</button>
</li>
}

