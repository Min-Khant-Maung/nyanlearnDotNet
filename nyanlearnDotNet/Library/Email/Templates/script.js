
document.addEventListener('DOMContentLoaded', function() {
  var selectElement = document.getElementById('courses_dd');

  selectElement.addEventListener('change', function() {
    var selectedCourseId = this.value;

    // Create the AJAX request
    var xhr = new XMLHttpRequest();

    xhr.open('GET', '/your-endpoint?courseId=' + selectedCourseId, true);

    xhr.onload = function() {
      if (xhr.status === 200) {
        var response = xhr.responseText;
        // Handle the success response
        console.log(response);
      } else {
        // Handle the error response
        console.error('Request failed. Status:', xhr.status);
      }
    };

    xhr.onerror = function() {
      // Handle any network errors
      console.error('Request failed. Network error.');
    };

    xhr.send();

    
  });
});

