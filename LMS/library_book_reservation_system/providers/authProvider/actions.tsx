import { createAction } from "redux-actions";
import { ILogin,IUser,IUserStateContext } from "./context";

export enum UserActionEnum{
    userLogin = "USER_LOGIN",
    createUser="CREATE_USER",
    getUserDetails="GET_USER_DETAILS",
    userLogout = 'USER_LOGOUT',
    setCurrentUser = 'SET_CURRENT_USER',
    getUserId = 'GET_USER_ID',
}

export const userLoginAction = createAction<IUserStateContext, ILogin>(UserActionEnum.userLogin,(login)=>({login}))
export const createUserAction=createAction<IUserStateContext,IUser>(UserActionEnum.createUser,(CreateUser)=>({CreateUser}));
export const getUserDetailsAction = createAction<IUserStateContext, number>(UserActionEnum.getUserDetails,(id)=>({}));
export const userLogoutAction = createAction<IUserStateContext>(UserActionEnum.userLogout,()=>({}))
export const setCurrentUserAction = createAction<IUserStateContext, IUser>(UserActionEnum.setCurrentUser,(currentUser)=>({currentUser}))
export const getUserIdAction = createAction<IUserStateContext, number>(UserActionEnum.getUserId, (userId) => ({ userId }));