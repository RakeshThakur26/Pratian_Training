export class AvailableSystem{
    system_name:string='';
    system_model:string='';
    
    constructor(_name:string, _model:string){
        this.system_name = _name;
        this.system_model = _model;
    }
}