export class NoteModel {

    constructor(


        public NoteID:BigInteger,
        public UserEmail:string,
        public Title:string,
        public Description:string,
        public CreatedDate:any,
        public ModifiedDate:any,
        public Images:string,
        public Reminder:string,
        public IsArchive:boolean,
        public IsTrash:boolean,
        public IsPin:boolean,
        public Color:boolean,
        public Labels:any,
        public Collabarators:any,
       

    ) {  }
}


