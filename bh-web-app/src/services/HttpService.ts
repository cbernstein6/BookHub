import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})

export class HttpService {
    private apiUrl: string = "http://localhost:5222";

    constructor(private http : HttpClient) { }

    getBooks(series: string) {
        return this.http.get(`${this.apiUrl}/api/Book/series/${series}`);
    }
}