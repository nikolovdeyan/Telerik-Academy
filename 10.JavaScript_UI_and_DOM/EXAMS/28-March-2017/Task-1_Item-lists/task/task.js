function solve() {
	return function(selector, defaultLeft, defaultRight) {
      function addItem(e) {
          var inputText = e.target.previousElementSibling.value.trim();

          if(inputText.length !== 0) {
              var selectedList;
              if(document.getElementById('leftCol').checked) {
                  selectedList = document.getElementById('leftCol').parentElement.nextElementSibling;
              } else if (document.getElementById('rightCol').checked) {
                  selectedList = document.getElementById('rightCol').parentElement.nextElementSibling;
              }
              var newItem = document.createElement('li');
              newItem.className = 'entry';
              newItem.innerHTML = inputText;
              var newItemImg = document.createElement('img');
              newItemImg.className = 'delete';
              newItemImg.src = 'imgs/Remove-icon.png';
              newItemImg.addEventListener('click', removeItem);
              newItem.appendChild(newItemImg);
              selectedList.appendChild(newItem);
          }
      }
      function removeItem(e) {
          var itemToRemove = e.target.parentElement;
          var inputFieldElement = document.getElementsByClassName('column-container')[0].nextElementSibling;
          inputFieldElement.value = itemToRemove.innerText;
          itemToRemove.parentElement.removeChild(itemToRemove);
      }

      var selectedElement = document.querySelector(selector);
      var leftColumnValues = (typeof defaultLeft === 'undefined' ||
                             defaultLeft === null) ? [] : defaultLeft;
      var rightColumnValues = (typeof defaultRight === 'undefined' ||
                              defaultRight === null) ? [] : defaultRight;

      var fragment = document.createDocumentFragment();

      var container = document.createElement('div');
      container.className = 'column-container';
      var inputField = document.createElement('input');
      inputField.setAttribute('type', 'text');
      var inputButton = document.createElement('button');
      inputButton.innerHTML = 'Add';
      inputButton.addEventListener('click', addItem);

      // Columns
      var leftColumn = document.createElement('div');
      leftColumn.className = 'column';
      var rightColumn = document.createElement('div');
      rightColumn.className = 'column';

      // Left Column
      var selectDiv = document.createElement('div');
      selectDiv.className = 'select';
      var radioButton = document.createElement('input');
      radioButton.setAttribute('id', 'leftCol');
      radioButton.setAttribute('type', 'radio');
      radioButton.setAttribute('name', 'button-group');
      radioButton.setAttribute('checked', 'true');
      selectDiv.appendChild(radioButton);

      var labelForButton = document.createElement('label');
      labelForButton.setAttribute('for', 'leftCol');
      labelForButton.innerHTML = 'Add here';
      selectDiv.appendChild(labelForButton);

      leftColumn.appendChild(selectDiv);

      var olElement = document.createElement('ol');
      for (var i = 0, len = leftColumnValues.length; i < len; i += 1) {
          var listItem = document.createElement('li');
          listItem.className = 'entry';
          listItem.innerText = leftColumnValues[i];
          var imgItem = document.createElement('img');
          imgItem.className = 'delete';
          imgItem.src = 'imgs/Remove-icon.png';
          imgItem.addEventListener('click', removeItem);
          listItem.appendChild(imgItem);
          olElement.appendChild(listItem);
      }

      leftColumn.appendChild(olElement);


      var selectDivRight = document.createElement('div');
      selectDivRight.className = 'select';
      var radioButtonRight = document.createElement('input');
      radioButtonRight.setAttribute('id', 'rightCol');
      radioButtonRight.setAttribute('type', 'radio');
      radioButtonRight.setAttribute('name', 'button-group');
      selectDivRight.appendChild(radioButtonRight);

      var labelForButtonRight = document.createElement('label');
      labelForButtonRight.setAttribute('for', 'rightCol');
      labelForButtonRight.innerHTML = 'Add here';
      selectDivRight.appendChild(labelForButtonRight);

      rightColumn.appendChild(selectDivRight);

      var olElementRight = document.createElement('ol');
      for (var j = 0, lenr = rightColumnValues.length; j < lenr; j += 1) {
          var listItemRight = document.createElement('li');
          listItemRight.className = 'entry';
          listItemRight.innerHTML = rightColumnValues[j];
          var imgItemRight = document.createElement('img');
          imgItemRight.className = 'delete';
          imgItemRight.src = 'imgs/Remove-icon.png';
          imgItemRight.addEventListener('click', removeItem);
          listItemRight.appendChild(imgItemRight);
          olElementRight.appendChild(listItemRight);
      }

      rightColumn.appendChild(olElementRight);

      container.appendChild(leftColumn);
      container.appendChild(rightColumn);
      fragment.appendChild(container);
      fragment.appendChild(inputField);
      fragment.appendChild(inputButton);
      selectedElement.appendChild(fragment);

	};
}