import { Component } from '@angular/core';
import { HttpService } from '../../services/HttpService';
import { SeriesDisplayComponent } from "./series-display/series-display.component";

@Component({
    selector: 'app-home',
    standalone: true,
    templateUrl: './home.component.html',
    styleUrl: './home.component.css',
    providers: [HttpService],
    imports: [SeriesDisplayComponent]
})
export class HomeComponent {

    harry: string = "Harry Potter";
    dune: string = "Dune";
    ice: string = "A Song of Ice and Fire";
}
