import MainScreen from './MainScreen'
import NavigationBar from './NavigationBar'
import 'bootstrap/dist/css/bootstrap.min.css';
import Sidebar from './Sidebar';
import { useState } from 'react';


function App() {
  const [selectedCuisine, setSelectedCuisine] = useState(1);
  const handleCuisineSelected = (cuisineId: number) => {
    setSelectedCuisine(cuisineId);
  };

  return (

    <div className="container">
      <div className="row">
        <div className="col-12 px-0">
          <NavigationBar />
        </div>
      </div>
      <div className="row">
        <div className="col-3 col-lg-2 border border-light">
          <Sidebar onCuisineSelected={handleCuisineSelected} />
        </div>


        <div className="col-9 col-lg-10">
          <MainScreen cuisineId={selectedCuisine} />
        </div>
      </div>
    </div>

  )
}

export default App
