

export default function Genero(Genero){

return <div className="Genero__card">
    <div className="Genero__photo-box">
        <img src="https://www.entretantomagazine.com/wp-content/uploads/2014/01/maxresdefault.jpg" alt="" className="Genero__photo"/>
    </div>
    <div className="Genero__card-info">
        <h1 className="Genero__nombre">{Genero.nombre}</h1>
    </div>
</div>

}