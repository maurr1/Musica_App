import axios from 'axios'
import "../sass/header.scss"
import Genero from "../Components/Genero/Genero"
import "../sass/generos.scss"
import "../sass/list.scss"
import "../sass/navigation.scss"
import Navigation from "../Components/Navigation/navigation"
import Cancion from "../Components/Cancion/Cancion"
import React, {useEffect, useState} from "react";
 const Home=()=>{

        const [generos, setGeneros] = useState([])

useEffect(() => { axios.get('https://localhost:44398/api/generos')
            .then(res => {
                setGeneros(res.data)
            })
}, [])


const [canciones, setCanciones] = useState([])

useEffect(() => { axios.get('https://localhost:44398/api/canciones')
            .then(res => {
                setCanciones(res.data)
            })
}, [])



    return <>
    <Navigation/>
    <header className="header">  
    </header>
    <section className="Genero">
<h1 className="Genero__title">Generos De electronica</h1>

    <div className="Genero__lista">
        {generos.map((genero)=>{
            console.log(genero.nombre);
            return <Genero key={genero.id} {...genero}/>
        })}
       
    </div>
</section>

<section className="cancion">
<h1 className="cancion__title">Canciones recomendadas</h1>
<ul className="cancion__lista">
        {canciones.map((cancion)=>{
            console.log(cancion.id);
            return <Cancion key={cancion.id} {...cancion}/>
        })}
</ul>
</section>
    
    </> 
}
export default Home;