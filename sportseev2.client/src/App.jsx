import React from 'react';
import './sass/main.scss';

import NavigationHorizontal from './components/NavigationHorizontal';
import NavigationVerticle from './components/NavigationVerticle';
import Dashboard from './Pages/Dashboard';
import Error from './Pages/Error';
import Home from './Pages/Home';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

/**
 * App component managing routing
 * @component
 * @example
 * returns (
 *  <App />
 * )
 */
function App() {
    return (
        <div className="App">
            <BrowserRouter>
                <header>
                    <NavigationHorizontal />
                    <NavigationVerticle />
                </header>
                <main className="app__container">

                    <Routes>
                        <Route path="/" element={<Home />} />
                        <Route path="/user/:id" element={<Dashboard />} />
                        <Route path="*" element={<Error />} />
                    </Routes>
                </main>
            </BrowserRouter>
        </div>
    );
}

export default App;
