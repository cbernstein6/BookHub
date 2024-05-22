import { Component, Input } from '@angular/core';
import { BookiconComponent } from '../bookicon/bookicon.component';
import { CommonModule } from '@angular/common';
import { Book } from '../../../services/Book';
import { HttpService } from '../../../services/HttpService';

@Component({
  selector: 'app-series-display',
  standalone: true,
  imports: [BookiconComponent, CommonModule],
  templateUrl: './series-display.component.html',
  styleUrl: './series-display.component.css'
})

export class SeriesDisplayComponent {
  books!: Book[];

  @Input() title!: string;

  constructor(private http : HttpService) { }
  ngOnInit(): void {
    this.http.getBooks(this.title).subscribe(books =>
    {
    this.books = Object.values(books);
    });
  }
}
