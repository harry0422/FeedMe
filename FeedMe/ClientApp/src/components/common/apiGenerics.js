
export const getJsonFromUrl = async url => {
    const response = await fetch(url, {
        headers: new Headers({
            'Content-Type': 'application/json'
        })
    });
    const data = await response.json();

    return data;
}

export const postJsonToUrl = async (url, requestJson) => {
    const response = await fetch(url, {
        headers: new Headers({
            'Content-Type': 'application/json'
        }),
        method: 'POST',
        body: requestJson,
    });

    return response;
}

export const putJsonToUrl = async (url, requestJson) => {
    const response = await fetch(url, {
        headers: new Headers({
            'Content-Type': 'application/json'
        }),
        method: 'PUT',
        body: requestJson,
    });

    return response;
}

export const deleteToUrl = async (url) => {
    await fetch(url, {
        headers: new Headers({
            'Content-Type': 'application/json'
        }),
        method: 'DELETE'
    });
}