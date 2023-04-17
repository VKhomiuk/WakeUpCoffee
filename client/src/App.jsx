import './App.css';
import Layout from './components/Layout/Layout';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Main from './pages/Main/Main';
import PlacePage from './pages/PlacePage/PlacePage';
import Cart from './pages/Cart/Cart';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Layout>
          <Routes>
            <Route path='/' element={<Main />} />
            <Route path='/place/:id' element={<PlacePage />} />
            <Route path='/cart' element={<Cart />} />
          </Routes>
        </Layout>
      </BrowserRouter>
    </div>
  );
}

export default App;
