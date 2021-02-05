import { getJsonFromUrl } from "../common/apiGenerics";

const USERS_URL = 'api/users/';

export const getUserByUserName = async userName => {
    return await getJsonFromUrl(USERS_URL + userName);
}