import axios from "axios";
import { useEffect } from "react";
import { useState } from "react";

function City() {

    const [response, setresponse] = useState([]);

    // responsible for calling the api
    const getdata = async () => {
        try {
            const res = await axios.get('https://localhost:5092/api/v1/city/1'); // using axios to do GET request
            setresponse(res.data);
        } catch (err) {
            console.log("error");
        }
    };

    useEffect( () => {
        getdata();
    } ,[]);

    if (response) {
        return (<h1> Bye {JSON.stringify(response)} </h1>);
    }
    else {
        return (<h1> Bye </h1>);
    }

  }
  
  export default City
  