import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Pipe4Component } from './pipe4.component';

describe('Pipe4Component', () => {
  let component: Pipe4Component;
  let fixture: ComponentFixture<Pipe4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Pipe4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Pipe4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
