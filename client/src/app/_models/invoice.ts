

export interface Invoice{
    id: string;
    seria : string;
    number : number;
    invoiceDate : Date;
    client: [];
    clientId: number;
    sum : number;
    totalSum :number;
    isPaid :number;
    items : [];    
}