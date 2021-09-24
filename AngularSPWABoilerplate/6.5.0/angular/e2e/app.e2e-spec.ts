import { boilerplatetestTemplatePage } from './app.po';

describe('boilerplatetest App', function() {
  let page: boilerplatetestTemplatePage;

  beforeEach(() => {
    page = new boilerplatetestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
