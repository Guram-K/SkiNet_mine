import { IProduct } from './product';

export interface IProducts {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: IProduct[];
}
