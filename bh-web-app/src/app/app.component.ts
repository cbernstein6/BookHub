import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./header/header.component";
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, HeaderComponent, HttpClientModule]
})
export class AppComponent {
  title = 'BookHub';

  bookdata: any;

  constructor(private http : HttpClient){}

  ngOnInit() {
  }
 
}
