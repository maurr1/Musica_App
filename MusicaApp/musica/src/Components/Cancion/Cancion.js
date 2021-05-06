
import axios from 'axios'
import React, {useEffect, useState} from "react";

export default function Cancion(cancion){
const [subgenero, setSubgenero] = useState([])
useEffect(() => { axios.get(`https://localhost:44398/api/detalle/${cancion.id}`)
            .then(res => {
                console.log(res.data);
                setSubgenero(res.data.subgenero)
            })
}, [])

  return <li className="cancion__item">
    <img src={cancion.imagen || "https://pluspng.com/img-png/user-png-icon-young-user-icon-2400.png"} alt="Foto de imagen" className="cancion__photo"/>
    <div className="cancion__info">
        <h3 className="cancion__nombre">{cancion.nombre}</h3>
        <p className="cancion__duracion">{cancion.duracion}</p>
    </div>
    <h3 className="cancion__title-small">{subgenero}</h3>
</li>



}