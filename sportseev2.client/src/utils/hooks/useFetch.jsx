import { useState, useEffect } from 'react'

const REACT_APP_API_BASE_URL = window.REACT_APP_API_BASE_URL;

export default function useFetch(endpoint) {
    const [response, setResponse] = useState(null)
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(false)

    const url = `${REACT_APP_API_BASE_URL}${endpoint}`;

    useEffect(() => {
        const doFetch = async () => {
        try {
            const res = await fetch(url);
            if(res.status === 200){
                const json = await res.json();
                setResponse(json);
            } else {
                setError(true)
            }
            
        } catch (err) {
            console.log(err)
            setError(true);
        } finally {
            setLoading(false);
        }
        };
        doFetch();
    }, [url]);
    return { response, loading , error};
}