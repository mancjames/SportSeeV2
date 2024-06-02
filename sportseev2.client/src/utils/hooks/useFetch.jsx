import { useState, useEffect } from 'react'

export default function useFetch(link) {
    const [response, setResponse] = useState(null)
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(false)

    useEffect(() => {
        const doFetch = async () => {
        try {
            const res = await fetch(link);
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
    }, [link]);
    return { response, loading , error};
}