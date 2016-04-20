function scalingaction=RobusT2Scalesg(x1,x2)

% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The scripts implements the sugeno fuzzy controller and
% produce the output which is the scaling action for horizontal elasticity.
% x1: workload (should be normalized in [0 100])
% x2: response time (should be normalized in [0 100])
% scalingaction: [-2 +2], this determines the change in the number of resources 
% ------------------------------------------------------------------------

%   Example:
%       output = RobusT2Scalesg(10,10)
%   This generates the response for example
%       output = -2


% reads the designed fuzzy controller which is based on sugeno fuzzy type
myfis=readfis('robust2scalesg.fis');

% Check the fis for empty values
checkfis(myfis);

% Issue warning if inputs out of range
inRange = getfis(myfis,'inRange');
InputMin = min([x1 x2]);
InputMax = max([x1 x2]);

if any(InputMin(:)<inRange(:,1)) | any(InputMax(:)>inRange(:,2))
   warning('Some input values are outside of the normalized range.')
end

% this determines the precision of reasoning calculation
numofpoints=101;

% this evaluates the output based on the defined MFs and the rule engine
% inside the fuzzy controller.
scalingaction = evalfismex([x1 x2],myfis,numofpoints);

end