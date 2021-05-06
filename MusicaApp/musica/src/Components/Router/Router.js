 import {
  BrowserRouter,
  Switch,
  Route,
  Redirect
} from 'react-router-dom';
import Home from '../../pages/home'
import Detalle from '../../pages/detalle'
import Login from '../../pages/login'
import Usuarios from '../../pages/usuarios'
export default function Router() {
  return (
    <div>
      <BrowserRouter>
        <Switch>
          <Route exact path="/" component={Home} />
          <Route path="/detalle" component={Detalle} />
          <Route path="/login" component={Login} />
          <Route path="/lista" component={Usuarios} />
        </Switch>
      </BrowserRouter>
    </div>
  );
}