import React, {useEffect, useState} from 'react'
import axios from 'axios';
import {Select, Button} from 'antd';

const Weather = () => {
  const baseUrl = "https://localhost:44322/api/"
  const [city, setCity] = useState([]);  
  const [weather,setWeather] = useState("");
  const [country, setCountry] = useState([]);
  const [weatherCity, setWeatherCity] = useState(null);

  const { Option } = Select;

  useEffect(() => {
    axios.get(baseUrl+`country`).then((response) => {
        setCountry(response.data);
    }) 
  })

  const ChangeKota = () => {
    axios.get(baseUrl+`weather?city=${weather}`).then((response) => {
        setWeatherCity(response.data);
    }) 
  }

  const handleSelected = (e) => {
    axios.get(baseUrl+`city?country=${e}`).then((response) => {
        setCity(response.data);
    }) 
    setCountry(e)
  }

  const handleSelectedCity = (e) => {
    setWeather(e)
  }

  
    return (
    <>
        <Select placeholder="Choose a country" onChange={handleSelected}  >
            {
              country.data?.map(country => (
                <Option value={country.name} >
                    {country.name}
                </Option>
              ))
            }
        </Select>
        <Select placeholder="Choose a city" onChange={handleSelectedCity}  >
            {
                
                city.data?.map(city => (
                    <Option value={city.name} >
                        {city.name}
                    </Option>
                ))
            }
        </Select>


        <Button onClick={ChangeKota} >Klik</Button>    
        {
            weatherCity == null ? (
                <p>No Data</p>
            ) : (
                <>
                <p>Name : {weatherCity.data?.name}</p>
                <p>Location : {weatherCity.data?.location}</p>
                <p>Time : {weatherCity.data?.time}</p>
                <p>Wind: {weatherCity.data?.wind}</p>
                <p>Visibility : {weatherCity.data?.visibility}</p>
                <p>Sky condition: {weatherCity.data?.sky_condition}</p>
                <p>Temp cel: {weatherCity.data?.temp_celcius}</p>
                <p>Temp Fahrenheit: {weatherCity.data?.temp_fahrenheit}</p>
                <p>Dew point: {weatherCity.data?.dew_point}</p>
                <p>Relative humidility: {weatherCity.data?.relative_humidility}</p>
                <p>Pressure : {weatherCity.data?.pressure}</p>
                </>
            )
        }
    </>
  )
}

export default Weather;