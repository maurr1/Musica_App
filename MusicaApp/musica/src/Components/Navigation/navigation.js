export default function Navigation(){
return<div className="navigation"> 
            <input type="checkbox" className="navigation__checkbox" id="navi-toggle"/>
            <label for="navi-toggle" className="navigation__button">
                <span className="navigation__icon">&nbsp;</span>
            </label>
            <div className="navigation__background">&nbsp;</div>
            <nav className="navigation__nav">
                <ul className="navigation__list">
                    <li className="navigation__item"><a href="/" class="navigation__link"><span>01</span>Home</a></li>
                    <li className="navigation__item"><a href="/login" class="navigation__link"><span>02</span>Login</a></li>
                    <li className="navigation__item"><a href="/lista" class="navigation__link"><span>03</span>Accounts</a></li>
                    <li className="navigation__item"><a href="#" class="navigation__link"><span>04</span>Canciones</a></li>
                    
                </ul>
            </nav>
    </div>

}