import './App.css';
import { Header } from './layout/Header';
import {BrowserRouter, Routes, Route} from 'react-router-dom';
import Weather from './pages/Weather';
import MyApi from './pages/MyApi';


function App() {
  return (
    <>
    <BrowserRouter>
      <Header/>
      <>
        <Routes>
          <Route path='/' element={<Weather/>} />
          <Route path='/myapi' element={<MyApi/>} />
        </Routes>
      </>
    </BrowserRouter>
      
    </>
  );
}

export default App;
