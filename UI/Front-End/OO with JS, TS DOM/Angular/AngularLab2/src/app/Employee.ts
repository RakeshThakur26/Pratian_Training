import { AvailableSystem } from "./AvailableSystem";

export class Employee{
    Ename:string='';
    Estatus:string='';
    Erequest:string='';
    Asyst : AvailableSystem ;
    status:string ='';
    req:string='';


    constructor(_name:string, _status:string, _req:string,_Sname:string, _model:string){
        this.Ename = _name;
        this.Estatus = _status;
        this.Erequest = _req;
        this.Asyst = new AvailableSystem(_Sname, _model);

        if(_status == "Active")
            this.status = 'green';
        else 
            this.status = 'red';    

        if(_req == 'Approved') 
            this.req = 'green';
        else if(_req == 'Rejected')
            this.req = 'red';
        else 
             this.req = 'yellow';           
    }
}