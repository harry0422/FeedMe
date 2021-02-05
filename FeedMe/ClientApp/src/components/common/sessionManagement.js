export var userIsLoggedIn = false;
export var userName = '';
export var userRole = '';

export const saveSession = (sessionInfo) => {

    console.log(sessionInfo);

    sessionStorage.setItem('firmas_token', sessionInfo.tokenType + ' ' + sessionInfo.accessToken);
    userIsLoggedIn = true;
    userName = sessionInfo.nombreEmpleado;
    userRole = sessionInfo.perfil
}

export const getToken = () => {
    return sessionStorage.getItem('firmas_token');
}