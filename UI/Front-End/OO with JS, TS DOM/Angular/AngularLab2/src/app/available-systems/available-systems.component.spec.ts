import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AvailableSystemsComponent } from './available-systems.component';

describe('AvailableSystemsComponent', () => {
  let component: AvailableSystemsComponent;
  let fixture: ComponentFixture<AvailableSystemsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AvailableSystemsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AvailableSystemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
